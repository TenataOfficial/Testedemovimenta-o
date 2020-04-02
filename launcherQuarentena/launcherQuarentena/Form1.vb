Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub




    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If parou = True Then
        Else
            If e.KeyCode = Keys.A Then
           
                moveu += 1
                PictureBox1.Location = New Point(PictureBox1.Location.X - 7, PictureBox1.Location.Y)

                If esq = 0 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X - 4, PictureBox1.Location.Y + 10)
                    esq += 1
                ElseIf esq = 1 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X - 4, PictureBox1.Location.Y + 3)
                    esq = 0
                End If

            ElseIf e.KeyCode = Keys.D Then
       
            If direi = 0 Then
                PictureBox7.Location = New Point(PictureBox1.Location.X + 24, PictureBox1.Location.Y + 10)
                direi += 1
            ElseIf direi = 1 Then
                PictureBox7.Location = New Point(PictureBox1.Location.X + 24, PictureBox1.Location.Y + 3)
                direi = 0
            End If

            moveu += 1
                PictureBox1.Location = New Point(PictureBox1.Location.X + 7, PictureBox1.Location.Y)
            Else

            End If
        If e.KeyCode = Keys.W Then
            moveu += 1
         
                If cim = 0 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X + 3, PictureBox1.Location.Y - 10)
                    cim += 1
                ElseIf cim = 1 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y - 10)
                    cim = 0
                End If

                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 7)
            ElseIf e.KeyCode = Keys.S Then
                If bai = 0 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X + 3, PictureBox1.Location.Y + 25)
                    bai += 1
                ElseIf bai = 1 Then
                    PictureBox7.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y + 25)
                    bai = 0
                End If
                moveu += 1
                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 7)
        End If
        If PictureBox1.Bounds.IntersectsWith(Nothing) = True Then
        Else
                If e.KeyCode = Keys.E Then
                    If inca = True Then
                        inca = False
                        Label13.Visible = True
                        mexer = True
                    ElseIf inca = False Then
                        inca = True
                        mexer = False

                    End If

                End If
        End If
            End If
    End Sub
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer2.Enabled = True
        Label10.Visible = False
        Label11.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel3.Location = New Point(PictureBox1.Location.X - 30, PictureBox1.Location.Y - 30)
        If Panel3.Bounds.IntersectsWith(Panel1.Bounds) = True Or Panel3.Bounds.IntersectsWith(Panel2.Bounds) = True Or Panel3.Bounds.IntersectsWith(Button4.Bounds) = True Then
            Timer1.Enabled = False
            MsgBox("Pressione E para interagir")
            Panel3.Visible = False

            cabo = True
            Timer3.Enabled = True

        Else


        End If
        If moveu = 50 Then
            Panel2.Location = New Point(80, 32)

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox6.Bounds.IntersectsWith(PictureBox1.Bounds) = True Then
            Timer2.Enabled = False
            moveu = 0
            MsgBox("Olá, tudo bem contigo?... Hoje eu irei te ensinar como funciona as coisas por aqui")
            mexer = False
            inca = True
            Panel3.Visible = True
            Timer1.Enabled = True
        Else
            If PictureBox1.Location.X < PictureBox6.Location.X Then
                PictureBox6.Location = New Point(PictureBox6.Location.X - 3, PictureBox6.Location.Y)
            ElseIf PictureBox1.Location.X > PictureBox6.Location.X Then
                PictureBox6.Location = New Point(PictureBox6.Location.X + 3, PictureBox6.Location.Y)
            End If
            If PictureBox1.Location.Y < PictureBox6.Location.Y Then
                PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y - 3)
            ElseIf PictureBox1.Location.Y > PictureBox6.Location.X Then
                PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y + 3)
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Button2.BackColor = Color.Yellow And cabo = True Then
            mexer = False
            cabo = False
            Panel3.Location = New Point(356, 224)
            MsgBox("Agora você sabe todos os controles kkkk", MsgBoxStyle.OkOnly)
            Panel1.Location = New Point(96, 94)
            mexer = False
            inca = True
        Else
        End If
        

        If PictureBox1.Bounds.IntersectsWith(Panel2.Bounds) = True And mexer = True Or Panel3.Bounds.IntersectsWith(Panel2.Bounds) = True And mexer = True Then
            If Button2.BackColor = Color.Cyan Then
                Button1.BackColor = Color.Cyan
                Button1.Text = "Começar"
                Button2.BackColor = Color.Yellow
                Button2.Text = "Créditos"
                mexer = False
                inca = True
            ElseIf Button2.BackColor = Color.Yellow Then
                Button2.BackColor = Color.Cyan
                Button1.BackColor = Color.Yellow
                Button2.Text = "Começar"
                Button1.Text = "Créditos"
                mexer = False
                inca = True
            End If
            mexer = False
        End If
        If PictureBox1.Bounds.IntersectsWith(Panel1.Bounds) = True And mexer = True Then
            If Button2.BackColor = Color.Cyan Then
                Timer4.Enabled = True
                Timer2.Enabled = False
                mexer = False
                Panel1.Visible = False
                Panel2.Visible = False
                mexer = False
                inca = True
                
            ElseIf Button2.BackColor = Color.Yellow Then
                mexer = False
                Button2.BackColor = Color.Cyan
                Button1.BackColor = Color.Yellow
                Button2.Text = "Começar"
                Button1.Text = "Créditos"
                MsgBox("Criado por mim kkkkk")
                MsgBox("Tenata")
                MsgBox("youtube.com/c/tenata0001")
                mexer = False
                inca = True
            End If
            mexer = False
        End If
    End Sub
  
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If PictureBox6.Bounds.IntersectsWith(PictureBox1.Bounds) = True Or PictureBox6.Location.X = PictureBox1.Location.X + 30 Then
            PictureBox6.Location = New Point(PictureBox1.Location.X + 30, PictureBox1.Location.Y)
            If bai = 10 Then
                bati = True
            ElseIf bai = 0 Then
                bati = False
            End If
            If bai < 10 And bati = False Then
                PictureBox7.Location = New Point(PictureBox1.Location.X + 3, PictureBox1.Location.Y + 20)
                bai += 1

            ElseIf bai <> 0 And bati = True Then
                PictureBox7.Location = New Point(PictureBox1.Location.X + 10, PictureBox1.Location.Y + 20)
                bai -= 1

            End If
            parou = True
            If cacau = False Then
            Else
                PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 1)
            End If
            If PictureBox1.Location.Y >= 200 Then
                cacau = False
                Timer5.Enabled = True
                Timer6.Enabled = True
                TextBox1.Visible = True

            End If
        Else
            If PictureBox6.Location.X = PictureBox1.Location.X + 30 And PictureBox6.Location.Y = PictureBox1.Location.Y Then
            Else
                If PictureBox6.Location.X = PictureBox1.Location.X + 30 Then

                Else
                    If PictureBox1.Location.X < PictureBox6.Location.X Then
                        PictureBox6.Location = New Point(PictureBox6.Location.X - 3, PictureBox6.Location.Y)
                    ElseIf PictureBox1.Location.X > PictureBox6.Location.X Then
                        PictureBox6.Location = New Point(PictureBox6.Location.X + 3, PictureBox6.Location.Y)
                    End If
                End If

                If PictureBox1.Location.Y < PictureBox6.Location.Y Then
                    PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y - 3)
                ElseIf PictureBox1.Location.Y > PictureBox6.Location.X Then
                    PictureBox6.Location = New Point(PictureBox6.Location.X, PictureBox6.Location.Y + 3)
                End If
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        maria += 1
        If maria = 1 Then
            Process.Start(songs)
        End If
        If maria = 2 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Bom venha comigo eu vou te contar tudo que aconteceu"
        ElseIf maria = 4 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Acho que devo me apresentar, como deu para perceber eu sou uma fantasma e eu sei do seu grande problema de insonia, andei te observando a algum tempo"
        ElseIf maria = 6 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Todas essas pessoas aqui fazem parte de sua jornada e cada um tem a sua função, eu por exemplo estou aqui para te ajudar, mas tem um problema a noite eu me transformo em algo horrivel"
        ElseIf maria = 8 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "A poucos dias aconteceu um acidente tragico que atingiu você a sua irmãzinha, e como eu me apeguei a ti eu resolvi te ajudar"
        ElseIf maria = 10 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "O ar lá fora está contaminado e necessita de 15 dias para tudo voltar ao normal enquanto isso afaste os demonios que tetarão levar a sua irmãzinha"
        ElseIf maria = 12 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Eu não posso fazer muita coisa pois meus poderes só ficam ativos a noite e eu só posso agir nos sonhos, fora deles eu sou uma besta"
        ElseIf maria = 14 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "A cada ajuda fora dos sonhos um preço é cobrado... Bem para tratar de sua insonia você terá que fazer algo que talves seja estranho para você"
        ElseIf maria = 16 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Eu ñem sei como dizer isso, mas você tera que se tocar e como sei que sua mãe é muito brava eu tentarei te avisar quando ela estiver chegando"
        ElseIf maria = 18 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Termine e você estará com sono então entrarei em seus sonhos e tentarei te ajudar, irei tentar me controlar o maximo que conseguir"
        ElseIf maria = 20 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Lembre-se que conversar com sua irmãzinha pode ajudar-los"
        ElseIf maria = 22 Then
            TextBox1.Text = TextBox1.Text & vbNewLine & "Bom... Vamos lá"

        ElseIf maria = 30 Then
            Button5.Visible = True
            bai = 20
            Timer4.Enabled = False
            PictureBox7.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y)
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Panel4.Location = New Point(Panel4.Location.X, Panel4.Location.Y - 3)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If PictureBox1.Bounds.IntersectsWith(Button4.Bounds) And mexer = True Then
            Timer7.Enabled = False
            MsgBox("Te vejo em outra hora")
            Process.Start(ss)
            Application.Exit()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start(ss)
        System.Threading.Thread.Sleep(800)
        Process.Start(lauv)
        Application.Exit()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If PictureBox1.Location.X >= 273 Then
            PictureBox1.Location = New Point(2, PictureBox1.Location.Y)
        ElseIf PictureBox1.Location.X <= 0 Then
            PictureBox1.Location = New Point(272, PictureBox1.Location.Y)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Process.Start(ss)
        MsgBox("Te vejo em outra hora")
        Application.Exit()
    End Sub
 
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If mexer = False Then
            Label13.Visible = False
        ElseIf mexer = True Then
            Label13.Location = New Point(PictureBox1.Location.X + 6, PictureBox1.Location.Y - 19)
        End If
    End Sub
End Class
