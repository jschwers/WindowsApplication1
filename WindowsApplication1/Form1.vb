Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Runtime.InteropServices


Public Class Form1

    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub setgaincomm(ByVal gain As Integer, ByVal command As Byte(), ByVal len As Integer)
    End Sub
    'return command of set reader gain
    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub getgaincomm(ByVal command As Byte(), ByVal len As Integer)
    End Sub
    'return command of get reader gain
    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub setmodecomm(ByVal mode As Integer, ByVal t1 As Integer, ByVal t2 As Integer, ByVal command As Byte(), ByVal len As Integer)
    End Sub
    'return command of  set reader work mode
    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub getbuffercomm(ByVal command As Byte(), ByVal len As Integer)
    End Sub
    'return command of get buff data
    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function getgainresp(ByVal data As Byte(), ByVal len As Integer) As Integer
    End Function

    <DllImport("Utility.dll", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function getdataresp(ByVal data As Byte(), ByVal len As Integer, ByVal resp As Byte()) As Integer
    End Function
    Private listener As Socket

    Private Const MAX_SOCKET As Integer = 10

    Private clientSocket As Socket
    Private Sub Listen()

        Try
            'server port is always 8900
            Dim nPort As Integer = 8900


            Dim iep As New IPEndPoint(IPAddress.Any, nPort) ' was IPAddress.Any
            listener = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

            listener.Bind(iep)
            listener.Listen(10)
            statusBar1.Panels(0).Text = "Port: " + nPort.ToString + "Listening......"


            listener.BeginAccept(New AsyncCallback(AddressOf AcceptCallback), listener)
        Catch generatedExceptionName As System.Security.SecurityException
            MessageBox.Show("Firewall safety error!", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Public Sub AcceptCallback(ByVal ar As IAsyncResult)
        Dim listener As Socket = DirectCast(ar.AsyncState, Socket)
        Dim client As Socket = listener.EndAccept(ar)

        Dim state As New StateObject()
        state.workSocket = client

        clientSocket = client

        Dim tempRemoteEP As EndPoint = client.RemoteEndPoint
        Dim tempRemoteIP As IPEndPoint = DirectCast(tempRemoteEP, IPEndPoint)
        Dim rempip As String = tempRemoteIP.Address.ToString()
        Dim remoport As String = tempRemoteIP.Port.ToString()
        GUIControl.IListBoxAddItem(Me, listBoxReaders, "[" + rempip + "] - Port:" + remoport)

        'start receiving data from reader
        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf readCallback), state)

        listener.BeginAccept(New AsyncCallback(AddressOf AcceptCallback), listener)
    End Sub
    Public Sub readCallback(ByVal ar As IAsyncResult)
        Try
            Dim state As StateObject = DirectCast(ar.AsyncState, StateObject)
            Dim handler As Socket = state.workSocket
            Dim bytesRead As Integer = handler.EndReceive(ar)
            If bytesRead > 0 Then

                Dim tempRemoteEp As EndPoint = handler.RemoteEndPoint
                Dim tempRemoteIP As IPEndPoint = DirectCast(tempRemoteEp, IPEndPoint)
                Dim rempip As String = tempRemoteIP.Address.ToString()
                Dim remoport As String = tempRemoteIP.Port.ToString()

                Dim recvBytes As Byte() = New Byte(2047) {}
                Dim number As String = Nothing
                Dim status As String = Nothing
                recvBytes = state.buffer

                'Judge data head
                If (recvBytes(0) = 66) AndAlso (recvBytes(1) = 73) AndAlso (recvBytes(2) = 83) AndAlso (recvBytes(3) = 65) AndAlso (recvBytes(4) = 95) AndAlso (recvBytes(5) = 82) AndAlso (recvBytes(6) = 70) AndAlso (recvBytes(7) = 73) AndAlso (recvBytes(8) = 68) AndAlso (recvBytes(9) = 0) Then

                    'judge data package type
                    If (recvBytes(14) = 1) OrElse (recvBytes(14) = 21) AndAlso (recvBytes(15) = 0) Then
                        Dim len As Integer = recvBytes(13) * 256 + recvBytes(12)

                        'starting from byte[48], every 13 byte is a reading record
                        For i As Integer = 0 To (len - 48) / 13 - 1
                            number = Nothing
                            status = Nothing

                            'find Tag ID
                            For j As Integer = 0 To 7
                                number += recvBytes(i * 13 + j + 48).ToString("X2")
                            Next

                            'find status
                            status = recvBytes(i * 13 + 8 + 48).ToString("X2")
                            GUIControl.IListBoxAddItem(Me, listBoxTags, "[" + rempip + "] - " + number + " - " + status)

                        Next
                    End If
                End If


                handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf readCallback), state)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Class StateObject
        Public workSocket As Socket = Nothing
        Public Const BufferSize As Integer = 2048
        Public buffer As Byte() = New Byte(BufferSize - 1) {}
        Public sb As New StringBuilder()

    End Class

    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click
        Listen()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.[Exit]()
    End Sub

    Private Sub buttonSetMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSetMode.Click

        Dim mode As Byte
        Dim T1 As Byte, T2 As Byte

        If radioButtonActive.Checked = True Then
            mode = 0
        Else
            mode = 1
        End If

        T1 = Convert.ToByte(textBoxT1.Text)
        T2 = Convert.ToByte(textBoxT2.Text)


        Dim cmd As Byte() = New Byte(47) {}

        'Header
        cmd(0) = 66
        cmd(1) = 73
        cmd(2) = 83
        cmd(3) = 65
        cmd(4) = 95
        cmd(5) = 82
        cmd(6) = 70
        cmd(7) = 73
        cmd(8) = 68
        cmd(9) = 0

        'Version
        cmd(10) = 0
        cmd(11) = 1

        'Length
        cmd(12) = 48
        cmd(13) = 0

        'Command
        cmd(14) = 160
        cmd(15) = 0

        'Parameters
        cmd(16) = mode
        cmd(17) = T1
        cmd(18) = T2

        'The Rest
        For i As Integer = 19 To 47
            cmd(i) = 0
        Next



        Me.clientSocket.Send(cmd)



    End Sub

    Private Sub buttonGetBuffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonGetBuffer.Click
        Dim cmd As Byte() = New Byte(47) {}

        'Header
        cmd(0) = 66
        cmd(1) = 73
        cmd(2) = 83
        cmd(3) = 65
        cmd(4) = 95
        cmd(5) = 82
        cmd(6) = 70
        cmd(7) = 73
        cmd(8) = 68
        cmd(9) = 0

        'Version
        cmd(10) = 0
        cmd(11) = 1

        'Length
        cmd(12) = 48
        cmd(13) = 0

        'Command
        cmd(14) = 21
        cmd(15) = 0

        'The Rest
        For i As Integer = 16 To 47
            cmd(i) = 0
        Next

        Me.clientSocket.Send(cmd)

    End Sub

    Private Sub buttonSetGain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSetGain.Click
        Dim cmd As Byte() = New Byte(99) {}
        Dim gain As Integer = Convert.ToInt32(textBoxGain.Text)

        'this method sets up a byte array to set gain, and store it in "cmd"
        'the array can be setted up manually. Please refer to the protocol document.
        setgaincomm(gain, cmd, 48)

        Me.clientSocket.Send(cmd)
    End Sub

    Private Sub buttonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClear.Click
        listBoxTags.Items.Clear()
    End Sub
End Class

