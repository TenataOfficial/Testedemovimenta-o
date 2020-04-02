Public Class Form1
    
   
   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = life
        ProgressBar3.Value = vdi
        Process.Start(slg)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Location = New Point(523, 12)
        miau = False
        If PictureBox1.BackColor = Color.Cyan Then
            Label5.Text = Label5.Text + 1
        ElseIf PictureBox1.BackColor = Color.Red Then
            Label5.Text = Label5.Text + 3
        End If
        If Timer3.Interval = 15 Then
        ElseIf Timer3.Interval > 15 And Label5.Text = 1 Or Label5.Text = 5 Or Label5.Text = 10 Or Label5.Text = 20 Or Label5.Text = 35 Or Label5.Text = 40 Or Label5.Text = 50 Or Label5.Text = 60 Or Label5.Text = 70 Or Label5.Text = 80 Or Label5.Text = 100 Or Label5.Text = 110 Or Label5.Text = 120 Or Label5.Text = 130 Or Label5.Text = 140 Then
            Timer3.Interval = (Timer3.Interval - cagu)
        End If
        If Timer1.Interval > 100 Then
            Timer1.Interval = sumon - 100

        Else
        End If
    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Location.X = 523 And PictureBox1.Location.Y = 12 = True Then
            intas = rnd.Next(3, 455)
            If cbl = True Then
                PictureBox1.BackColor = Color.Pink
                cbl = False
            ElseIf cbl = False And PictureBox1.BackColor = Color.Red = False Or PictureBox1.BackColor = Color.Pink = False Then
                PictureBox1.BackColor = Color.Cyan
            End If
            PictureBox1.Location = New Point(intas, 3)
        Else
        End If
        
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.X = 523 Then
        Else
            If PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) = True Then
                If PictureBox1.BackColor = Color.Cyan Then
                    Label5.Text = Label5.Text + 1
                ElseIf PictureBox1.BackColor = Color.Red Then
                    Label5.Text = Label5.Text + 3
                    life += 3
                ElseIf PictureBox1.BackColor = Color.Pink Then
                    Label5.Text = Label5.Text + 5
                    vdi += 3
                End If
            End If
            If PictureBox1.Bounds.IntersectsWith(Panel2.Bounds) = True Then
                cabe += 1
                If PictureBox1.BackColor = Color.Cyan Then
                    life -= 1
                ElseIf PictureBox1.BackColor = Color.Red Then
                    life -= 3
                ElseIf PictureBox1.BackColor = Color.Pink Then
                    life -= 10
                End If
            End If
            If PictureBox1.Bounds.IntersectsWith(Panel2.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) = True Then
                miau = False
                PictureBox1.Location = New Point(523, 12)

            Else
                miau = True
            End If
        End If
        If Label5.Text = 10 Or Label5.Text = 20 Or Label5.Text = 30 Or Label5.Text = 40 Or Label5.Text = 50 Or Label5.Text = 60 Or Label5.Text = 70 Then
            PictureBox1.BackColor = Color.Red
        Else

        End If
        If cabe = 10 Then
            nr = 0
            Label5.Text = 0
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            Panel5.Visible = True
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label5.Visible = False
            Label8.Visible = False
            Timer16.Enabled = True
            Timer7.Enabled = True
            Label1.Text = "ACORDADÂO"
            diaa += 1
            carinho += 3
        End If
        
    End Sub
    
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If miau = True Then
            PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 10)
        End If
    End Sub

   
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If PictureBox2.Location.Y < 26 Then
        Else
            If e.KeyCode = Keys.W Then
                PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y - 7)
                If cim = 0 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 3, PictureBox2.Location.Y - 6)
                    cim += 1
                ElseIf cim = 1 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 10, PictureBox2.Location.Y - 6)
                    cim = 0
                End If
            End If
        End If
        If PictureBox2.Location.Y > 329 Then
        Else
            If e.KeyCode = Keys.S Then
                PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y + 7)
                If bai = 0 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 3, PictureBox2.Location.Y + 17)
                    bai += 1
                ElseIf bai = 1 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 10, PictureBox2.Location.Y + 17)
                    bai = 0
                End If
            End If
        End If
        If PictureBox2.Location.X < 3 Or PictureBox2.Location.X > 463 Then
            If PictureBox2.Location.X < 3 Then
                PictureBox2.Location = New Point(461, PictureBox2.Location.Y)
            End If
            If PictureBox2.Location.X > 463 Then
                PictureBox2.Location = New Point(3, PictureBox2.Location.Y)
            End If
        Else
            If e.KeyCode = Keys.A Then
                PictureBox2.Location = New Point(PictureBox2.Location.X - 7, PictureBox2.Location.Y)
                If esq = 0 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X - 4, PictureBox2.Location.Y + 10)
                    esq += 1
                ElseIf esq = 1 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X - 4, PictureBox2.Location.Y + 3)
                    esq = 0
                End If
            ElseIf e.KeyCode = Keys.D Then
                PictureBox2.Location = New Point(PictureBox2.Location.X + 7, PictureBox2.Location.Y)

                If direi = 0 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 18, PictureBox2.Location.Y + 10)
                    direi += 1
                ElseIf direi = 1 Then
                    PictureBox16.Location = New Point(PictureBox2.Location.X + 18, PictureBox2.Location.Y + 3)
                    direi = 0
                End If
            End If
        End If
        If e.KeyCode = Keys.E Then
            If oasd = False Then
                mexer = True
                oasd = True
            ElseIf oasd = True Then
                mexer = False
                Label12.Visible = False
                oasd = False
            End If
        End If



        If e.KeyCode = Keys.F Then
            If flf = 0 Then
                flf += 1
            Else
                flf = 0
            End If
        End If
        If e.KeyCode = Keys.L Then
            If flf = 1 Then
                flf += 1
            Else
                flf = 0
            End If
        End If
        If e.KeyCode = Keys.Y Then
            If flf = 2 Then

                If fly = False Then
                    Timer21.Enabled = True
                    Panel8.Visible = True
                    fly = True
                    flf = 0
                    cheat = 10
                ElseIf fly = True Then
                    Timer21.Enabled = False
                    Panel8.Visible = False
                    fly = False
                    flf = 0
                    cheat = 10
                End If

            End If
        End If



        If e.KeyCode = Keys.X Then
            If dq = 0 Then
                dq += 1
            Else
                flf = 0
            End If
        End If
        If e.KeyCode = Keys.I Then
            If dq = 1 Then
                dq += 1
            Else
                dq = 0
            End If
        End If
        If e.KeyCode = Keys.V Then
            If dq = 2 Then
                diaa = 14
                cheat = 10
            Else
                dq = 0
            End If

        End If

        If e.KeyCode = Keys.P Then
            If pop = 0 Then
                pop += 1
            ElseIf pop = 2 Then
                pop = 0
                cheat = 10
                carinho = 10
            ElseIf pop = 1 Then
                pop = 0

            End If
        End If
        If e.KeyCode = Keys.O Then
            If pop = 1 Then
                pop += 1
            Else
                pop = 0
            End If
        End If

        If e.KeyCode = Keys.Q Then
            If cond = False Then
                cond = True
                Me.Size = New Size(486 ^ 2, 368 ^ 2)
                Me.Location = New Point(Me.Location.X / 2, Me.Location.Y / 2)

            ElseIf cond = True Then
                cond = False
                Me.Size = New Size(486, 368)
                Me.Location = New Point(Me.Location.X ^ 2, Me.Location.Y ^ 2)

            End If
        End If
    End Sub
   
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        If carlinhos = False Then
            If TrackBar1.Value = 0 Then
                punhe += 1
                carlinhos = True
            End If
        ElseIf carlinhos = True Then
            If TrackBar1.Value = 10 Then
                punhe += 1
                carlinhos = False
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
    End Sub
   
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick


        If punhe = 20 Or punhe = 40 Or punhe = 70 Or punhe = 100 Then
            If ct = True Then
            Else
                mae = True
                Timer5.Enabled = True
            End If

        End If

        If mae = True Then
            If PictureBox3.Location.X < 366 Then
                mae = False
                ct = True
            Else
                PictureBox3.Location = New Point(PictureBox3.Location.X - 3, PictureBox3.Location.Y)

            End If
        End If

        If ct = True Then
            If PictureBox3.Location.X > 520 Then
                ct = False
                Timer5.Enabled = False
            Else
                PictureBox3.Location = New Point(PictureBox3.Location.X + 3, PictureBox3.Location.Y)

            End If
        End If
        If punhe >= 150 Then
            Panel3.Visible = False
            punhe = 0
            Label1.Text = "SONO"
            Me.Focus()
            kkk = True
        Else
            ProgressBar2.Value = punhe
        End If
        If vdi <= 1 Or vdi > 100 Then
        ElseIf vdi >= 1 And vdi <= 100 Then
            ProgressBar3.Value = vdi
        End If

        If PictureBox3.Bounds.IntersectsWith(Label4.Bounds) Then
            mp = punhe
        Else

        End If

        If punhe > 50 Then
            dv = True
        End If
     

    End Sub
    Dim cond As Boolean = False


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If PictureBox3.Location.X < 480 Then
            Label3.Visible = True
            If mp <> punhe And PictureBox3.Location.X <= 432 = True Then
                Timer5.Enabled = False
                punhe = 0
               
                K2 = K.Next(1, 3)
                If K2 = 1 Then
                    MsgBox("MAS QUE POUCA VERGONHA É ESSA AQUI EM MINHA CASA, MAS QUE PORRA, AGORA VOCÊ VAI APANHAR", MsgBoxStyle.OkOnly)
                ElseIf K2 = 2 Then
                    MsgBox("VOCÊ ESTÁ LOUCO EU VOU TE MATAR AGORA", MsgBoxStyle.OkOnly)
                ElseIf K2 = 3 Then
                    MsgBox("VOCÊ ESTÁ LOUCO", MsgBoxStyle.OkOnly)
                End If
                negociar = 0
                life -= 20
                Panel3.Visible = False
                Me.Focus()
            End If
            Else
                Label3.Visible = False
            End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If dv = True And punhe > 1 And Label3.Visible = False Then

            punhe -= 1
        ElseIf dv = True And punhe <= 1 Then
            dv = False
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick


        If PictureBox2.Bounds.IntersectsWith(PictureBox11.Bounds) = True Then

        Else

            If PictureBox2.Location.X > PictureBox11.Location.X Then
                PictureBox11.Location = New Point(PictureBox11.Location.X + 1, PictureBox11.Location.Y)
            ElseIf PictureBox2.Location.X < PictureBox11.Location.X Then
                PictureBox11.Location = New Point(PictureBox11.Location.X - 1, PictureBox11.Location.Y)
            End If
            If PictureBox2.Location.Y > PictureBox11.Location.Y Then
                PictureBox11.Location = New Point(PictureBox11.Location.X, PictureBox11.Location.Y + 1)
            ElseIf PictureBox2.Location.Y < PictureBox11.Location.Y Then
                PictureBox11.Location = New Point(PictureBox11.Location.X, PictureBox11.Location.Y - 1)
            End If
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer8_Tick_1(sender As Object, e As EventArgs) Handles Timer8.Tick
        If PictureBox3.Location.X < 480 Then
        Else
            Label3.Visible = False
        End If

        If mexer = True And PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) = False Or mexer = True And PictureBox2.Bounds.IntersectsWith(PictureBox10.Bounds) = True And Label1.Text <> "SONO" Then

        ElseIf PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) = True And mexer = True Then
            Panel3.Visible = True
            Panel3.Focus()
            PictureBox2.Location = New Point(23, 88)
            PictureBox16.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y)
            mexer = False
        End If




        If PictureBox2.Bounds.IntersectsWith(PictureBox10.Bounds) = True And mexer = True And Label1.Text = "SONO" Then
           
                Timer7.Enabled = False
                Timer1.Enabled = True
                Timer2.Enabled = True
                Timer3.Enabled = True
                Label5.Visible = True
                Label8.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                Panel5.Visible = False
                PictureBox11.Location = New Point(520, 165)
                mexer = False

        End If


        If Label5.Text >= 10 And kkk = True Then
            kkk = False
            lig = li.Next(0, 501)
            lim = lg.Next(19, 346)
            PictureBox11.Location = New Point(lig, lim)
            Timer7.Enabled = True
        End If
        Label6.Text = diaa
    End Sub
   
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If PictureBox2.Bounds.IntersectsWith(PictureBox11.Bounds) = True Then
            life -= 1
            negociar += 1
        End If
       
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
       
        If life >= 100 Or life < 0 Then
        Else
            ProgressBar1.Value = life
        End If

     

        If Label5.Text >= 30 Then
            nr = 0
            Label5.Text = 0
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            Panel5.Visible = True
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Label5.Visible = False
            Label8.Visible = False
            Timer16.Enabled = True
            Timer7.Enabled = True
            Label1.Text = "ACORDADÂO"
            diaa += 1
            carinho += 3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        life -= 3
        Panel4.Visible = False
        negociar = 0
        Me.Focus()
        emp = erd.Next(0, 4)
        If emp <= 1 Then
            PictureBox11.Location = New Point(PictureBox11.Location.X - 25, PictureBox11.Location.Y)
        ElseIf emp >= 2 Then
            PictureBox11.Location = New Point(PictureBox11.Location.X - 10, PictureBox11.Location.Y)
        End If
        
    End Sub
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.Aqua Then
            Button1.BackColor = Color.Aqua
            Button2.BackColor = Color.Yellow
            Button1.Text = "GILETE"
            Button2.Text = "CORDA"
        Else
            Button2.BackColor = Color.Aqua
            Button1.BackColor = Color.Yellow
            Button2.Text = "GILETE"
            Button1.Text = "CORDA"
        End If
    End Sub
    Public corda As Integer = 0
    Public gilete As Integer = 0

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button2.BackColor = Color.Yellow Then
            corda += 1
            life -= 5
        ElseIf Button2.BackColor = Color.Aqua Then
            gilete += 3
            life -= 6
        End If
        Panel4.Visible = False
        Me.Focus()
        negociar = 0
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        If Label1.Text = "SONO" Then
        Else
            If demon.Bounds.IntersectsWith(Panel5.Bounds) = True Then

            Else
                If snm = True Then
                    If Panel5.Location.X > demon.Location.X Then
                        demon.Location = New Point(demon.Location.X + 1, demon.Location.Y)
                    ElseIf Panel5.Location.X < demon.Location.X Then
                        demon.Location = New Point(demon.Location.X - 1, demon.Location.Y)
                    End If
                    If Panel5.Location.Y > demon.Location.Y Then
                        demon.Location = New Point(demon.Location.X, demon.Location.Y + 1)
                    ElseIf Panel5.Location.Y < demon.Location.Y Then
                        demon.Location = New Point(demon.Location.X, demon.Location.Y - 1)
                    End If
                Else

                End If
                End If
        End If
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        sn = soltar.Next(0, 21)
        If Label1.Text = "SONO" Then
            demon.Location = New Point(520, 278)
        Else

            If sn = 7 Then
                snm = True
                muke = kakareco.Next(0, 490)
                mulaa = bunda.Next(0, 10)
                demon.Location = New Point(muke, mulaa)
            Else
            End If
        End If
    End Sub
    



    Private Sub EscolhasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscolhasToolStripMenuItem.Click

    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        If demon.Bounds.IntersectsWith(PictureBox2.Bounds) = True Then
            If chutar = 1 Then
                Timer13.Enabled = False
                Timer11.Enabled = True
                snm = False
                life -= 8
                chutar = 0
                demon.Location = New Point(520, 278)
            ElseIf chutar = 2 Then
                Timer13.Enabled = False
                Timer11.Enabled = True
                life -= 1
                demon.Location = New Point(520, 278)
                snm = False
                chutar = 0
            End If
        Else

            If PictureBox2.Location.X > demon.Location.X Then
                demon.Location = New Point(demon.Location.X + 1, demon.Location.Y)
            ElseIf PictureBox2.Location.X < demon.Location.X Then
                demon.Location = New Point(demon.Location.X - 1, demon.Location.Y)
            End If
            If PictureBox2.Location.Y > demon.Location.Y Then
                demon.Location = New Point(demon.Location.X, demon.Location.Y + 1)
            ElseIf PictureBox2.Location.Y < demon.Location.Y Then
                demon.Location = New Point(demon.Location.X, demon.Location.Y - 1)
            End If
        End If
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        If PictureBox2.Bounds.IntersectsWith(demon.Bounds) And mexer = True Then
            Panel6.Visible = True
            Panel6.Focus()
            Panel6.Location = New Point(demon.Location.X, demon.Location.Y - 20)
            Timer11.Enabled = False
            mexer = False
        End If

        If PictureBox2.Bounds.IntersectsWith(Panel5.Bounds) And mexer = True And carinho >= 1 Then
            mexer = False
            cci = rdi.Next(0, 7)
            vdi += 3
            life += 1
            carinho -= 1
            Label12.Visible = False
            If cci = 1 Then
                MsgBox("Tive um pesadelo pensei que havia alguem me observando dormir", MsgBoxStyle.OkOnly)
            ElseIf cci = 2 Then
                MsgBox("Irmão eu sonhei que havia coisas escondidas por aqui", MsgBoxStyle.OkOnly)
            ElseIf cci = 3 Then
                MsgBox("Cof Cof, ainda acordado ?! ^-^ ", MsgBoxStyle.OkOnly)

            ElseIf cci = 4 Then
                MsgBox("Eu fiz uma piada que fez todos chorarem, eu era a piada  ;-;", MsgBoxStyle.OkOnly)
            ElseIf cci = 5 Then
                cca = mihg.Next(1, 10)
                If cca <> 2 Then
                    MsgBox("De manhã escutei uma musica da jhoane, a voz dela me deixa feliz", MsgBoxStyle.OkOnly)
                ElseIf cca = 2 Then
                    MsgBox("Acho que não somos irmãos ;-;", MsgBoxStyle.OkOnly)
                End If
            ElseIf cci = 6 Then
                cca = mihg.Next(1, 10)
                If cca <= 2 Then
                    MsgBox("Já tentou digitar fly em seu teclado?", MsgBoxStyle.OkOnly)
                ElseIf cca >= 3 Then
                    MsgBox("Eu escolho pedra kkk", MsgBoxStyle.OkOnly)

                End If

            End If
            Me.Focus()
        ElseIf PictureBox2.Bounds.IntersectsWith(Panel5.Bounds) And mexer = True And carinho = 0 Then
            mexer = False
            Label12.Visible = False
            MsgBox("Desculpe mas estou cansadinha agora ;-;")
        End If
        If ProgressBar3.Value = 0 Then
            life -= 1
        End If
        If diaa = 15 Then
            diaa = 0

            MsgBox("Parabéns você conseguiu sobreviver aos 15 dias de quarentena Renata.... " & vbNewLine & "Espero que tenha gostado de jogar esse jogo e agora já podemos apagar os &arquivos&", MsgBoxStyle.OkOnly)
            Process.Start(som)
            Application.Exit()
        End If
    End Sub
    
    Private Sub GileteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GileteToolStripMenuItem.Click
        If gilete >= 1 Then

            Timer11.Enabled = True
            Timer13.Enabled = True
            gilete -= 1
            chutar = 2
            snm = False
        ElseIf gilete = 0 Then
            MsgBox("Você não pode dar seu sangue porque não tem mais gilete", MsgBoxStyle.OkOnly)
            Timer11.Enabled = True
        End If
        Panel6.Visible = False
        Me.Focus()
    End Sub

    Private Sub InfinitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfinitoToolStripMenuItem.Click
        Timer11.Enabled = False
        Timer13.Enabled = True
        Panel6.Visible = False
        mexer = False
        Label12.Visible = False

        Me.Focus()
        chutar = 1
    End Sub



    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        If demon.Bounds.IntersectsWith(Panel5.Bounds) Then
            vdi -= 1
        End If
        
    End Sub
   
    Private Sub CordaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CordaToolStripMenuItem.Click
        If corda >= 1 Then
            Timer11.Enabled = False
            demon.Location = New Point(520, 278)
            Panel6.Visible = False
            Timer13.Enabled = False
            corda -= 1
            Me.Focus()
        ElseIf corda = 0 Then
            MsgBox("Você não tem a corda")
            Panel6.Visible = False
            Timer11.Enabled = True
            Me.Focus()
        End If
    End Sub

    
  
    

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Panel3.Visible = False
        Me.Focus()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Application.Exit()
        Process.Start(som)
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick

        If diaa > diam Then
            Timer16.Enabled = False
            Timer12.Interval = Timer12.Interval - 50
            diam = diaa

        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs)
        Label1.Text = "SONO"
    End Sub

    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        carba = madu.Next(0, 11)
        If carba = 4 Then
            cbl = True
        Else
        End If
    End Sub

    Private Sub Timer18_Tick(sender As Object, e As EventArgs) Handles Timer18.Tick

        If PictureBox2.Bounds.IntersectsWith(PictureBox11.Bounds) And mexer = True And Label1.Text = "SONO" = False Then
            mexer = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Panel4.Visible = True
            Label12.Visible = False
            life -= 3
            negociar = 0
        End If
    End Sub

    Private Sub Timer19_Tick(sender As Object, e As EventArgs) Handles Timer19.Tick
        If life <= 0 Then
            Timer19.Enabled = False
            MsgBox("Eu achei que você conseguiria, se quiser eu tentarei usar o meu poder para voltar no tempo")
            Panel7.Visible = True
            Timer13.Enabled = False
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Eu sinto muito, falhei em te ajudar")
        Process.Start(som)
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Bom, vamos tentar novamente então")
        Process.Start(som)
        nra = falhei.Next(0, 15)
        If nra = 7 Then
            MsgBox("Me perdoe eu infelizmente falhei, me perdoe ;-;")
            Process.Start(som)
            Application.Exit()
        Else
            Application.Restart()
        End If


    End Sub

    Private Sub Timer20_Tick(sender As Object, e As EventArgs) Handles Timer20.Tick
        If mexer = True Then
            Label12.Visible = True
            Label12.Location = New Point(PictureBox2.Location.X + 6, PictureBox2.Location.Y - 26)
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox11.Bounds) = True And mexer = True Or PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) = True And mexer = True Or PictureBox2.Bounds.IntersectsWith(PictureBox10.Bounds) = True And mexer = True Or PictureBox2.Bounds.IntersectsWith(demon.Bounds) And mexer = True Or PictureBox2.Bounds.IntersectsWith(Panel5.Bounds) And mexer = True Or PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) = True And mexer = True Then
            Label12.Visible = False
            PictureBox16.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y)
            oasd = False
        End If


    End Sub
  

    Private Sub Timer21_Tick(sender As Object, e As EventArgs) Handles Timer21.Tick
            Panel8.Location = New Point(PictureBox11.Location.X - 35, PictureBox11.Location.Y - 28)
    End Sub

    Private Sub Timer22_Tick(sender As Object, e As EventArgs) Handles Timer22.Tick
        If cheat <= 0 Then

            Label13.Visible = False
        ElseIf cheat >= 1 Then
            Label13.Visible = True
            cheat -= 1
        End If
    End Sub
End Class
