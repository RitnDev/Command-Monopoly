<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CmdMonopoly
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CmdMonopoly))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUD_NbrJoueurs = New System.Windows.Forms.NumericUpDown()
        Me.Panel_Prepa = New System.Windows.Forms.Panel()
        Me.BP_ValiderPrepa = New System.Windows.Forms.Button()
        Me.Panel_Joueur8 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel_Joueur5 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel_Joueur6 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel_Joueur7 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel_Joueur3 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_Joueur4 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel_Joueur2 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_Joueur1 = New System.Windows.Forms.Panel()
        Me.TB_Pseudo1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_MontantDep = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_InGame = New System.Windows.Forms.Panel()
        Me.LB_Flux = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LB_Commence = New System.Windows.Forms.Label()
        Me.Actualisation = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Plateau = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_7 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_8 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_6 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_5 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_4 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_3 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_2 = New System.Windows.Forms.Panel()
        Me.Panel_Jeton_1 = New System.Windows.Forms.Panel()
        CType(Me.NUD_NbrJoueurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Prepa.SuspendLayout()
        Me.Panel_Joueur8.SuspendLayout()
        Me.Panel_Joueur5.SuspendLayout()
        Me.Panel_Joueur6.SuspendLayout()
        Me.Panel_Joueur7.SuspendLayout()
        Me.Panel_Joueur3.SuspendLayout()
        Me.Panel_Joueur4.SuspendLayout()
        Me.Panel_Joueur2.SuspendLayout()
        Me.Panel_Joueur1.SuspendLayout()
        Me.Panel_InGame.SuspendLayout()
        Me.Panel_Plateau.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nbr de Joueur(s) :"
        '
        'NUD_NbrJoueurs
        '
        Me.NUD_NbrJoueurs.Location = New System.Drawing.Point(157, 9)
        Me.NUD_NbrJoueurs.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NUD_NbrJoueurs.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NUD_NbrJoueurs.Name = "NUD_NbrJoueurs"
        Me.NUD_NbrJoueurs.Size = New System.Drawing.Size(49, 27)
        Me.NUD_NbrJoueurs.TabIndex = 1
        Me.NUD_NbrJoueurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_NbrJoueurs.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Panel_Prepa
        '
        Me.Panel_Prepa.Controls.Add(Me.BP_ValiderPrepa)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur8)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur5)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur6)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur7)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur3)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur4)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur2)
        Me.Panel_Prepa.Controls.Add(Me.Panel_Joueur1)
        Me.Panel_Prepa.Controls.Add(Me.Label6)
        Me.Panel_Prepa.Controls.Add(Me.Label4)
        Me.Panel_Prepa.Controls.Add(Me.Label3)
        Me.Panel_Prepa.Controls.Add(Me.TB_MontantDep)
        Me.Panel_Prepa.Controls.Add(Me.Label2)
        Me.Panel_Prepa.Controls.Add(Me.Label1)
        Me.Panel_Prepa.Controls.Add(Me.NUD_NbrJoueurs)
        Me.Panel_Prepa.Location = New System.Drawing.Point(12, 404)
        Me.Panel_Prepa.Name = "Panel_Prepa"
        Me.Panel_Prepa.Size = New System.Drawing.Size(604, 391)
        Me.Panel_Prepa.TabIndex = 2
        '
        'BP_ValiderPrepa
        '
        Me.BP_ValiderPrepa.Location = New System.Drawing.Point(68, 123)
        Me.BP_ValiderPrepa.Name = "BP_ValiderPrepa"
        Me.BP_ValiderPrepa.Size = New System.Drawing.Size(185, 37)
        Me.BP_ValiderPrepa.TabIndex = 36
        Me.BP_ValiderPrepa.Text = "Valider"
        Me.BP_ValiderPrepa.UseVisualStyleBackColor = True
        '
        'Panel_Joueur8
        '
        Me.Panel_Joueur8.Controls.Add(Me.TB_Pseudo8)
        Me.Panel_Joueur8.Controls.Add(Me.Label11)
        Me.Panel_Joueur8.Location = New System.Drawing.Point(342, 343)
        Me.Panel_Joueur8.Name = "Panel_Joueur8"
        Me.Panel_Joueur8.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur8.TabIndex = 35
        '
        'TB_Pseudo8
        '
        Me.TB_Pseudo8.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo8.Name = "TB_Pseudo8"
        Me.TB_Pseudo8.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo8.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "8."
        '
        'Panel_Joueur5
        '
        Me.Panel_Joueur5.Controls.Add(Me.TB_Pseudo5)
        Me.Panel_Joueur5.Controls.Add(Me.Label9)
        Me.Panel_Joueur5.Location = New System.Drawing.Point(342, 211)
        Me.Panel_Joueur5.Name = "Panel_Joueur5"
        Me.Panel_Joueur5.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur5.TabIndex = 32
        '
        'TB_Pseudo5
        '
        Me.TB_Pseudo5.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo5.Name = "TB_Pseudo5"
        Me.TB_Pseudo5.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo5.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "5."
        '
        'Panel_Joueur6
        '
        Me.Panel_Joueur6.Controls.Add(Me.TB_Pseudo6)
        Me.Panel_Joueur6.Controls.Add(Me.Label12)
        Me.Panel_Joueur6.Location = New System.Drawing.Point(342, 255)
        Me.Panel_Joueur6.Name = "Panel_Joueur6"
        Me.Panel_Joueur6.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur6.TabIndex = 33
        '
        'TB_Pseudo6
        '
        Me.TB_Pseudo6.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo6.Name = "TB_Pseudo6"
        Me.TB_Pseudo6.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo6.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 19)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "6."
        '
        'Panel_Joueur7
        '
        Me.Panel_Joueur7.Controls.Add(Me.TB_Pseudo7)
        Me.Panel_Joueur7.Controls.Add(Me.Label13)
        Me.Panel_Joueur7.Location = New System.Drawing.Point(342, 299)
        Me.Panel_Joueur7.Name = "Panel_Joueur7"
        Me.Panel_Joueur7.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur7.TabIndex = 34
        '
        'TB_Pseudo7
        '
        Me.TB_Pseudo7.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo7.Name = "TB_Pseudo7"
        Me.TB_Pseudo7.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo7.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 19)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "7."
        '
        'Panel_Joueur3
        '
        Me.Panel_Joueur3.Controls.Add(Me.TB_Pseudo3)
        Me.Panel_Joueur3.Controls.Add(Me.Label7)
        Me.Panel_Joueur3.Location = New System.Drawing.Point(342, 123)
        Me.Panel_Joueur3.Name = "Panel_Joueur3"
        Me.Panel_Joueur3.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur3.TabIndex = 30
        '
        'TB_Pseudo3
        '
        Me.TB_Pseudo3.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo3.Name = "TB_Pseudo3"
        Me.TB_Pseudo3.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo3.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "3."
        '
        'Panel_Joueur4
        '
        Me.Panel_Joueur4.Controls.Add(Me.TB_Pseudo4)
        Me.Panel_Joueur4.Controls.Add(Me.Label10)
        Me.Panel_Joueur4.Location = New System.Drawing.Point(342, 167)
        Me.Panel_Joueur4.Name = "Panel_Joueur4"
        Me.Panel_Joueur4.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur4.TabIndex = 31
        '
        'TB_Pseudo4
        '
        Me.TB_Pseudo4.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo4.Name = "TB_Pseudo4"
        Me.TB_Pseudo4.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo4.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "4."
        '
        'Panel_Joueur2
        '
        Me.Panel_Joueur2.Controls.Add(Me.TB_Pseudo2)
        Me.Panel_Joueur2.Controls.Add(Me.Label8)
        Me.Panel_Joueur2.Location = New System.Drawing.Point(342, 79)
        Me.Panel_Joueur2.Name = "Panel_Joueur2"
        Me.Panel_Joueur2.Size = New System.Drawing.Size(227, 45)
        Me.Panel_Joueur2.TabIndex = 29
        '
        'TB_Pseudo2
        '
        Me.TB_Pseudo2.Location = New System.Drawing.Point(59, 5)
        Me.TB_Pseudo2.Name = "TB_Pseudo2"
        Me.TB_Pseudo2.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo2.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "2."
        '
        'Panel_Joueur1
        '
        Me.Panel_Joueur1.Controls.Add(Me.TB_Pseudo1)
        Me.Panel_Joueur1.Controls.Add(Me.Label5)
        Me.Panel_Joueur1.Location = New System.Drawing.Point(342, 38)
        Me.Panel_Joueur1.Name = "Panel_Joueur1"
        Me.Panel_Joueur1.Size = New System.Drawing.Size(227, 42)
        Me.Panel_Joueur1.TabIndex = 28
        '
        'TB_Pseudo1
        '
        Me.TB_Pseudo1.Location = New System.Drawing.Point(59, 6)
        Me.TB_Pseudo1.Name = "TB_Pseudo1"
        Me.TB_Pseudo1.Size = New System.Drawing.Size(136, 27)
        Me.TB_Pseudo1.TabIndex = 20
        Me.TB_Pseudo1.Text = "RitnTV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "1."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Pseudo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "€"
        '
        'TB_MontantDep
        '
        Me.TB_MontantDep.Location = New System.Drawing.Point(157, 53)
        Me.TB_MontantDep.Name = "TB_MontantDep"
        Me.TB_MontantDep.Size = New System.Drawing.Size(59, 27)
        Me.TB_MontantDep.TabIndex = 3
        Me.TB_MontantDep.Text = "2500"
        Me.TB_MontantDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Montant de départ :"
        '
        'Panel_InGame
        '
        Me.Panel_InGame.Controls.Add(Me.LB_Flux)
        Me.Panel_InGame.Controls.Add(Me.Label14)
        Me.Panel_InGame.Controls.Add(Me.LB_Commence)
        Me.Panel_InGame.Location = New System.Drawing.Point(12, 13)
        Me.Panel_InGame.Name = "Panel_InGame"
        Me.Panel_InGame.Size = New System.Drawing.Size(334, 376)
        Me.Panel_InGame.TabIndex = 3
        '
        'LB_Flux
        '
        Me.LB_Flux.AutoSize = True
        Me.LB_Flux.Location = New System.Drawing.Point(31, 73)
        Me.LB_Flux.Name = "LB_Flux"
        Me.LB_Flux.Size = New System.Drawing.Size(21, 19)
        Me.LB_Flux.TabIndex = 38
        Me.LB_Flux.Text = "..."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(246, 19)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Récupération des infos de transfert :"
        '
        'LB_Commence
        '
        Me.LB_Commence.AutoSize = True
        Me.LB_Commence.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Commence.Location = New System.Drawing.Point(5, 5)
        Me.LB_Commence.Name = "LB_Commence"
        Me.LB_Commence.Size = New System.Drawing.Size(86, 29)
        Me.LB_Commence.TabIndex = 0
        Me.LB_Commence.Text = "En jeu :"
        '
        'Actualisation
        '
        '
        'Panel_Plateau
        '
        Me.Panel_Plateau.BackgroundImage = CType(resources.GetObject("Panel_Plateau.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Plateau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_7)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_8)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_6)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_5)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_4)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_3)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_2)
        Me.Panel_Plateau.Controls.Add(Me.Panel_Jeton_1)
        Me.Panel_Plateau.Location = New System.Drawing.Point(920, 70)
        Me.Panel_Plateau.Name = "Panel_Plateau"
        Me.Panel_Plateau.Size = New System.Drawing.Size(800, 800)
        Me.Panel_Plateau.TabIndex = 4
        '
        'Panel_Jeton_7
        '
        Me.Panel_Jeton_7.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_7.Location = New System.Drawing.Point(748, 761)
        Me.Panel_Jeton_7.Name = "Panel_Jeton_7"
        Me.Panel_Jeton_7.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_7.TabIndex = 3
        '
        'Panel_Jeton_8
        '
        Me.Panel_Jeton_8.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_8.Location = New System.Drawing.Point(768, 760)
        Me.Panel_Jeton_8.Name = "Panel_Jeton_8"
        Me.Panel_Jeton_8.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_8.TabIndex = 4
        '
        'Panel_Jeton_6
        '
        Me.Panel_Jeton_6.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_6.Location = New System.Drawing.Point(730, 761)
        Me.Panel_Jeton_6.Name = "Panel_Jeton_6"
        Me.Panel_Jeton_6.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_6.TabIndex = 2
        '
        'Panel_Jeton_5
        '
        Me.Panel_Jeton_5.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_5.Location = New System.Drawing.Point(705, 760)
        Me.Panel_Jeton_5.Name = "Panel_Jeton_5"
        Me.Panel_Jeton_5.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_5.TabIndex = 2
        '
        'Panel_Jeton_4
        '
        Me.Panel_Jeton_4.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_4.Location = New System.Drawing.Point(769, 730)
        Me.Panel_Jeton_4.Name = "Panel_Jeton_4"
        Me.Panel_Jeton_4.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_4.TabIndex = 2
        '
        'Panel_Jeton_3
        '
        Me.Panel_Jeton_3.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_3.Location = New System.Drawing.Point(748, 730)
        Me.Panel_Jeton_3.Name = "Panel_Jeton_3"
        Me.Panel_Jeton_3.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_3.TabIndex = 2
        '
        'Panel_Jeton_2
        '
        Me.Panel_Jeton_2.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_2.BackgroundImage = CType(resources.GetObject("Panel_Jeton_2.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Jeton_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_2.Location = New System.Drawing.Point(726, 730)
        Me.Panel_Jeton_2.Name = "Panel_Jeton_2"
        Me.Panel_Jeton_2.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_2.TabIndex = 1
        '
        'Panel_Jeton_1
        '
        Me.Panel_Jeton_1.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Jeton_1.BackgroundImage = CType(resources.GetObject("Panel_Jeton_1.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Jeton_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Jeton_1.Location = New System.Drawing.Point(705, 730)
        Me.Panel_Jeton_1.Name = "Panel_Jeton_1"
        Me.Panel_Jeton_1.Size = New System.Drawing.Size(25, 25)
        Me.Panel_Jeton_1.TabIndex = 0
        '
        'CmdMonopoly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 821)
        Me.Controls.Add(Me.Panel_Plateau)
        Me.Controls.Add(Me.Panel_InGame)
        Me.Controls.Add(Me.Panel_Prepa)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CmdMonopoly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Command Monopoly"
        CType(Me.NUD_NbrJoueurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Prepa.ResumeLayout(False)
        Me.Panel_Prepa.PerformLayout()
        Me.Panel_Joueur8.ResumeLayout(False)
        Me.Panel_Joueur8.PerformLayout()
        Me.Panel_Joueur5.ResumeLayout(False)
        Me.Panel_Joueur5.PerformLayout()
        Me.Panel_Joueur6.ResumeLayout(False)
        Me.Panel_Joueur6.PerformLayout()
        Me.Panel_Joueur7.ResumeLayout(False)
        Me.Panel_Joueur7.PerformLayout()
        Me.Panel_Joueur3.ResumeLayout(False)
        Me.Panel_Joueur3.PerformLayout()
        Me.Panel_Joueur4.ResumeLayout(False)
        Me.Panel_Joueur4.PerformLayout()
        Me.Panel_Joueur2.ResumeLayout(False)
        Me.Panel_Joueur2.PerformLayout()
        Me.Panel_Joueur1.ResumeLayout(False)
        Me.Panel_Joueur1.PerformLayout()
        Me.Panel_InGame.ResumeLayout(False)
        Me.Panel_InGame.PerformLayout()
        Me.Panel_Plateau.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NUD_NbrJoueurs As NumericUpDown
    Friend WithEvents Panel_Prepa As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_MontantDep As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Pseudo2 As TextBox
    Friend WithEvents TB_Pseudo1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel_Joueur8 As Panel
    Friend WithEvents TB_Pseudo8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel_Joueur5 As Panel
    Friend WithEvents TB_Pseudo5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel_Joueur6 As Panel
    Friend WithEvents TB_Pseudo6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel_Joueur7 As Panel
    Friend WithEvents TB_Pseudo7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel_Joueur3 As Panel
    Friend WithEvents TB_Pseudo3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_Joueur4 As Panel
    Friend WithEvents TB_Pseudo4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel_Joueur2 As Panel
    Friend WithEvents Panel_Joueur1 As Panel
    Friend WithEvents BP_ValiderPrepa As Button
    Friend WithEvents Panel_InGame As Panel
    Friend WithEvents LB_Commence As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Actualisation As Timer
    Friend WithEvents LB_Flux As Label
    Friend WithEvents Panel_Plateau As Panel
    Friend WithEvents Panel_Jeton_1 As Panel
    Friend WithEvents Panel_Jeton_7 As Panel
    Friend WithEvents Panel_Jeton_8 As Panel
    Friend WithEvents Panel_Jeton_6 As Panel
    Friend WithEvents Panel_Jeton_5 As Panel
    Friend WithEvents Panel_Jeton_4 As Panel
    Friend WithEvents Panel_Jeton_3 As Panel
    Friend WithEvents Panel_Jeton_2 As Panel
End Class
