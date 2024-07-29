' John Piliounis  / ATLASCOM - ELECTROSYSTEMS / ATHENS - HELLAS (Greece)
' MARCH - 2008
' Aplication: This is an ASYNCHRONOUS, MULTITHREADED with EVENTS, SOCKET TCP SERVER
' PERFORMANCE:
' This aplication has been tested under heavy network connection demands. As you can see at the ProgressBar1 update
' SUB, the limits are set high. I have reached 800 connections, all requested and serviced almost within the same 
' tiny time frame and all of them were also sending data at the same time (immediately after connection accepted by
' this server). This server crashed at about 832 simultaneous connections on a PC with 4GB of RAM, Windows-2000 OR/AND XP, 
' due to memory exhaust and virtual_memory_low situations. Tests have also been done on 64-PCs with 8GB of RAM but due to 
' results that seem to be unreal I'm cross checking many parameters of this app to verify VS's and VB's real limits.
' Soon, results will be posted here.
' As in any project, the creator of this one, is just another informatics coalminer. Gredits go to the generations of
' information technology pioneers. A special thanks has to be addressed to the author of the "Practical .NET 2.0 Networking
' Projects" book, Wei-Meng Lee, who explains in great depth and detail, right from the first chapter, all the esoteric and
' cryptic issues related to Multithreaded, Asynchronous Socket, Server & Client apps implementation. The rest of the book
' is also a treasure on programming methods and real examples on Serial Communications, IR programming, RFID and lots 
' more. Lots of other articles, books and MSDN related material has been also studied.
'
' Lets get into the App's internal  now. These days there are hundrends of hardware network modules and also software 
' network ' clients that serve innumerable needs, ranging from simple DAQ to very complex real-time communication 
' systems.
' So, in most cases, a quick-in-action and robust server is needed in order not only to serve hundrends or/and thousands  
' of connection requests, but also manage the incoming and passing-through data of each one of them, in a robust and
' fully deterministic manner. In my project, I listen for connection requests from certain hardware and/or software
' modules, I accept them and I also do some processing on their incoming data. Filters may be implemented so to accept
' connections only from certain IP blocks or domains.
' To reply back to my clients, I only need to send a certain byte-stream, you can see it in the SendMessage method of 
' the SirionClient class, but you can use this method from anywhere in your project to send any kind of data you want,
' back to your clients. Also, you can use the ReceiveMessage / SendMessage methods combination in order to pass 
' messages from client to client from those that are already connected [ chat application ].
' 
' As you will read in the SirionClient class comments, the Sockets are not always closed in a proper manner or in time
' by the remote clients, hardware or software. Due to common mistakes on firmware designs, or untested acceptances of 
' how the hardware should behave in runtime in real life use, or even due to mistaken assesments on how software
' objects and instantiations are implemented by different OOPL vendors, there are times that client sockets although
' are ordered to close or shut down they don't. Unexpired timers, or uncontroled command execution orders often result 
' in either phantom open sockets or actually unclosed sockets. A resolution to this potential problem can be 
' implemented by the use of timers in the server side. 
' But this is usually usefull only on synchronous TCP communications with deterministic behaviour. Even more, the use 
' of timers and their event handling code, adds one more layer of complexity into our applications. The superiority of 
' the Asynchronous Server-Client communication method is obvious in all cases, since 99% of the times when a server's 
' receiving socket buffer is empty,  communication is over and although a remote socket closed message has not been 
' received, our code can safely decide and shut the open socket down. Many more can be said and discussed on this issue.
'
' You can use any socket client application and run it against this server, many-many times concurrently and watch the
' results. In case of any MAJOR difficulty or any other MAJOR issue regarding this application drop me an e-mail to
' jopil@electrosystems.gr [ Please make sure your subject line contains the word DYNASERVER ]
' Have a good time and REMEMBER, this code is for free use from all of us and as such should not reflect to a  
' money-profit reuse, use or abuse. As the ancient wise PYTHAGOREANS were saying :"Everything Common Everybody Owns",
' or more close to the original Hellenic words: "Undistributable All(everything), All(everybody) Have(own 
' or have access to)" 


Imports System.Threading


Public Class Form1
    
    'Public Shared whoConnected As String = ""      ' Tests
    'Public Shared whoDisconnected As String = ""   ' Tests
    'Public Shared dataSTR As String = ""           ' Tests

    Public WithEvents connected As SirionClient     ' Events that are fired from within the threads of the SirionClient 
    Public WithEvents disconnected As SirionClient  ' Class
    Public WithEvents datain As SirionClient        ' There are, all three, self descriptive 

    Dim BeginServer As New Thread(AddressOf ServerBegin)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False
        ' If we don't declare the above, we can't access FORM1 Variables and Controls from inside threads.
        ' We do this only if we are 98% sure that our threads actions are properly synclocked at runtime.
        ' There is a lot of hype why Microsoft in VS-2003 was allowing this to happen and in VS-2005 had to 
        ' implement this mechanism. A lot can be said on this but not here and not now. Many articles are
        ' available on this issue. Any suggestions are welcome at jopil@atlascom.gr

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D

        AddHandler SirionClient.whocon, AddressOf whoConnected_changed          ' The Handlers of the above Events
        AddHandler SirionClient.whodiscon, AddressOf whodisconnected_Changed
        AddHandler SirionClient.datain, AddressOf datain_changed

        ' The name of my Async Threaded Class as SirionClient is due to the fact that the network modules that
        ' my apllication's project has to monitor Real_Time, are named SIRION. The name was given by the Hellenic 
        ' company PARADOX HELLAS that designs and manufactures them.  http://www.paradox.gr/

        Label2.Text = Application.ProductName.ToString ' Here we make use of the trick that we describe in detail,
        ProgressBar1.Minimum = 0                       ' five SUBs below 
        ProgressBar1.Maximum = 10

        recording.globalRec = 0 'Set local Recording to ON
        Button3.PerformClick()

    End Sub

    Private Sub whoConnected_changed(ByVal whoConnected As String) Handles connected.whocon  ' Actions when events happen

        Log("Connection Requested from : " & whoConnected)
        update_Connections()

    End Sub

    Private Sub whoDisconnected_changed(ByVal whoDisconnected As String) Handles disconnected.whodiscon ' Actions when events happen

        Log(whoDisconnected & " > Disconnected")
        update_Connections()

    End Sub

    Private Sub datain_changed(ByVal datastr As String) Handles datain.datain ' Actions when events happen

        Log(datastr)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button1.Enabled = False
        Log("ATLASCOM  -  DAQ NetServer")
        Log("Network Real Time Monitoring Center")

        BeginServer.Start()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' This application may run multiple times on the same PC, for different Network-Cards with different IPs each.       ' For doing so, wou'll need to make as many builds for this application as the number of your network cards.
        ' You would need to do this if the remote network modules, whatever they are, Hardware or Software clients
        ' that you are servicing with this server, do have the ability to try connections to different/alternative IPs
        ' when WAN access to the server is not possible from one IP. 
        ' To create multiple Application & Product binaries of this very same binary named DynaServer, before 
        ' yoy press the button to start building the project, go to the PROJECT-Options pane and change "Assemply Name", 
        ' from DynaServer to DynaServer_1 or DynaServer_2  < AND ALSO > press the "Assembly Information" button, to 
        ' access the "Product Name" field. There ALSO CHANGE DynaServer to DynaServer_1 or DynaServer_2. 
        ' So, after two or more compilations with different Application & Product names,  you eventually get the same 
        ' EXE binary with different Application-Process Names and also different Product Names. 
        ' These changes can be traped from inside your code with the use of the Process Enum Class inside a For/Next 
        ' loop --> (Dim localApp As Process = Process.GetProcsses & For Each loc_proc As Process In localApp / 
        ' Do Something / Next) and by also using the Application.ProductName property, to compare.
        ' So, in your code you can discriminate which binary is running and accordingly having it bind at RUNTIME 
        ' with different internal or hardware settings.  
        ' Examples: a)Local_IP_Address to bind, b)USBs / Serial Ports to bind, c) Graphic Controllers 
        ' d) Processors [ Symmetric Parallel Multiprocessing ] e.t.c.

        Dim localApp As Process() = Process.GetProcesses

        For Each ep As Process In localApp
            If ep.ProcessName = Application.ProductName Then
                ep.Kill()
            End If
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If recording.globalRec = 0 Then
            recording.globalRec = 1
        Else
            recording.globalRec = 0
        End If

        If recording.globalRec = 1 Then
            Label1.Text = "Remote Clients Bytes are  Recorded Localy"
        Else
            Label1.Text = "No Local Data Recording of Remote Clients" ' Only Screen
        End If

    End Sub

    Sub ServerBegin()

        Dim localServer As New Module1      ' The Listener Class (Server.vb)
        localServer.mainListen()

    End Sub

    Private Sub Log(ByVal str As String)    ' Just Display received data on Text Box

        TextBox1.AppendText(str & vbCrLf)
        TextBox1.Select(TextBox1.TextLength - 1, 0)
        TextBox1.ScrollToCaret()

    End Sub


    Private Sub update_Connections() ' Here we learn and display in Real-Time how many clients are connected.

        ' Auto-Normalization of the Progress Bar dsiplay area for 
        ' 10,100,1000 or more concurrent connections

        Dim i As Integer = SirionClient.AllSirions.Count
        ' AllSirions is a Hash Table declared inside the SirionClient Class, as you can see and keeps 
        ' track of the different IP_End-Points ( clients ) that connect and disconnect from this Server
        ' Application

        If i <= 10 Then
            ProgressBar1.Maximum = 10
        ElseIf i > 10 And i <= 100 Then
            ProgressBar1.Maximum = 100
        ElseIf i > 100 And i <= 1000 Then
            ProgressBar1.Maximum = 1000
        ElseIf i > 1000 Then
            ProgressBar1.Maximum = 3000
        End If

        ProgressBar1.Value = i
        ProgressBar1.Update()
        Label4.Text = i.ToString

    End Sub


End Class


Public Class recording
    Public Shared globalRec As Integer = 0 ' Remote Clients Data / Bytes are  Recorded Localy (1) or Not (0), Button3_Click
End Class


