Imports System.IO
Imports ClassMD



Public Class CmdMonopoly

    'Déclaration des variables :
    Dim cheminEXE As String
    Dim cheminOriginal As String
    Dim cheminIDJoueurTXT As String
    Dim cheminMonopolyTXT As String
    Dim cheminLancerTXT As String
    Dim cheminLancerSpéTXT As String
    Dim cheminIndicationsTXT As String
    'Dim cheminTourTXT As String

    Dim Monopoly(0 To 8, 0 To 3) As String
    Dim pseudo(0 To 8) As String
    Dim montants(0 To 8) As Integer
    Dim plateau(0 To 40, 0 To 4) As Integer
    Dim Joueurs_Plateau(0 To 8) As Integer
    Dim Dé(0 To 216, 0 To 1) As String
    Dim tour As Integer

    Dim lancer As New Random
    Dim Dé_ligne1, Dé_ligne2 As Integer
    Dim NbErreurs As Integer

    'Constantes
    Const locX As Integer = 1
    Const locY As Integer = 2
    Const SizeL As Integer = 3
    Const SizeH As Integer = 4




#Region "Routines"

    'Initialisation des données du Plateau
    Sub Init_Plateau()
        Dim c As Integer = 0

        'Case Départ
        plateau(c, locX) = 700
        plateau(c, locY) = 700
        plateau(c, SizeL) = 101
        plateau(c, SizeH) = 101

        'Case 1 à 9
        Dim varX As Integer = 699

        For c = 1 To 9
            varX -= 66
            plateau(c, locX) = varX
            plateau(c, locY) = 725
            plateau(c, SizeL) = 64
            plateau(c, SizeH) = 76
        Next

        'Case 10
        c = 10
        plateau(c, locX) = 0
        plateau(c, locY) = 775
        plateau(c, SizeL) = 100
        plateau(c, SizeH) = 26

        'Case 11 à 19
        varX = 699

        For c = 11 To 19
            varX -= 66
            plateau(c, locX) = 0
            plateau(c, locY) = varX
            plateau(c, SizeL) = 76
            plateau(c, SizeH) = 64
        Next

        'Case 20
        c = 20
        plateau(c, locX) = 0
        plateau(c, locY) = 0
        plateau(c, SizeL) = 100
        plateau(c, SizeH) = 100

        'Case 21 à 29
        varX = 37

        For c = 21 To 29
            varX += 66
            plateau(c, locX) = varX
            plateau(c, locY) = 0
            plateau(c, SizeL) = 64
            plateau(c, SizeH) = 76
        Next

        'Case 30
        c = 30
        plateau(c, locX) = 700
        plateau(c, locY) = 0
        plateau(c, SizeL) = 100
        plateau(c, SizeH) = 100

        'Case 31 à 39
        varX = 37

        For c = 31 To 39
            varX += 66
            plateau(c, locX) = 725
            plateau(c, locY) = varX
            plateau(c, SizeL) = 64
            plateau(c, SizeH) = 76
        Next

        'Case 40
        c = 40
        plateau(c, locX) = 26
        plateau(c, locY) = 700
        plateau(c, SizeL) = 73
        plateau(c, SizeH) = 73



    End Sub

    'Actualise les fichiers joueurs
    Sub ActualiseJoueur(ByVal IDjoueur As Integer, ByVal montant As Integer)

        Dim fichier As New System.IO.StreamWriter(Monopoly(IDjoueur, 3))
        fichier.WriteLine("(" & IDjoueur & ") - " & pseudo(IDjoueur))
        fichier.WriteLine(montant)
        fichier.Close()

    End Sub

    'Positionne un jeton
    Sub Positionne_Jeton(ByVal IDJoueur As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal visible As Boolean)
        Select Case IDJoueur
            Case 1
                Panel_Jeton_1.Location = New Point(X, Y)
                Panel_Jeton_1.Visible = visible
            Case 2
                Panel_Jeton_2.Location = New Point(X, Y)
                Panel_Jeton_2.Visible = visible
            Case 3
                Panel_Jeton_3.Location = New Point(X, Y)
                Panel_Jeton_3.Visible = visible
            Case 4
                Panel_Jeton_4.Location = New Point(X, Y)
                Panel_Jeton_4.Visible = visible
            Case 5
                Panel_Jeton_5.Location = New Point(X, Y)
                Panel_Jeton_5.Visible = visible
            Case 6
                Panel_Jeton_6.Location = New Point(X, Y)
                Panel_Jeton_6.Visible = visible
            Case 7
                Panel_Jeton_7.Location = New Point(X, Y)
                Panel_Jeton_7.Visible = visible
            Case 8
                Panel_Jeton_8.Location = New Point(X, Y)
                Panel_Jeton_8.Visible = visible
            Case Else
        End Select
    End Sub

    'Actualise le placement des Jetons sur le plateau
    Sub Actualise_Jetons()
        Dim j As Integer

        'Init Plateau "Nombre de joueur"
        For j = 0 To 40
            plateau(j, 0) = 0
        Next

        For j = 1 To 8

            If j <= NUD_NbrJoueurs.Value Then
                Select Case Joueurs_Plateau(j)
                    Case 0
                        plateau(0, 0) += 1
                        If plateau(0, 0) = 1 Then
                            Positionne_Jeton(j, 705, 730, True)
                        Else
                            If plateau(0, 0) < 5 Then
                                Positionne_Jeton(j, 705 + (20 * (plateau(0, 0) - 1)), 730, True)
                            Else
                                Positionne_Jeton(j, 705 + (20 * (plateau(0, 0) - 5)), 760, True)
                            End If
                        End If

                    Case 1 To 19

                End Select
            Else
                Positionne_Jeton(j, 800, 800, False)
            End If

        Next



    End Sub

    'Génère le dé
    Sub Generation_dé(ByVal normal As Integer, ByVal special As Integer)

        Dé_ligne1 = normal
        Dé_ligne2 = special

        Dim fichier As New System.IO.StreamWriter(cheminEXE & "Dé.txt")

        'For i = 0 To NUD_NbrJoueurs.Value

        'If ID = tour Then
        fichier.WriteLine(Dé(Dé_ligne1, 0))
        ' Else
        'fichier.WriteLine("")
        'End If

        'Next


        fichier.WriteLine(Dé(Dé_ligne1, 1))
        fichier.Close()



    End Sub


    'Actualise le fichier Indications
    Sub Actualise_Indications(ByVal contenu As String)

        Dim fichier As New System.IO.StreamWriter(cheminIndicationsTXT)
        fichier.WriteLine(contenu)
        fichier.Close()

    End Sub

    Sub Tour_suivant()

        'Recherche du tour actuel et incrémentation
        tour += 1
        If tour > NUD_NbrJoueurs.Value Then
            tour = 1
        End If

        'Dim fichier As New System.IO.StreamWriter(cheminTourTXT)
        'fichier.WriteLine(pseudo(tour))
        'fichier.Close()

    End Sub

#End Region


#Region "Fenêtre Principale"


    'Lancement de la fenêtre principale
    Private Sub CmdMonopoly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Récupère le chemin d'où est executer le logiciel
        cheminEXE = Mid(Application.ExecutablePath, 1, Len(Application.ExecutablePath) - (Len(Me.Text) + 4))
        'Initialise les variables des chemmin d'accès
        cheminOriginal = cheminEXE & "Original\"
        cheminIDJoueurTXT = cheminEXE & "IDJoueur.txt"
        cheminMonopolyTXT = cheminEXE & "Monopoly.txt"
        cheminLancerTXT = cheminOriginal & "dé.txt"
        cheminLancerSpéTXT = cheminOriginal & "dé spécial.txt"
        cheminIndicationsTXT = cheminEXE & "Indications.txt"
        'cheminTourTXT = cheminEXE & "Tour.txt"

        'Initialisation des variables "Plateau"
        Init_Plateau()
        Actualise_Indications("La partie va bientôt commencer !")
        NbErreurs = 0

        'Initialise la taille de la fenêtre
        Me.Size = New Point(644, 451)
        Me.MaximumSize = New Point(644, 451)
        Me.MinimumSize = New Point(644, 451)

        'Initialise les Panels
        Panel_Prepa.Location = New Point(12, 12)
        Panel_Prepa.Visible = True
        Panel_InGame.Location = New Point(12, 12)
        Panel_InGame.Visible = False
        Panel_Plateau.Location = New Point(352, 12)
        Panel_Plateau.Size = New Point(800, 800)
        Panel_Plateau.Visible = False

    End Sub


#End Region




#Region "Panel Prepa"

    'Choix du nombres de joueurs
    Private Sub NUD_NbrJoueurs_ValueChanged(sender As Object, e As EventArgs) Handles NUD_NbrJoueurs.ValueChanged

        Panel_Joueur1.Visible = True
        Panel_Joueur2.Visible = True
        Panel_Joueur3.Visible = False
        Panel_Joueur4.Visible = False
        Panel_Joueur5.Visible = False
        Panel_Joueur6.Visible = False
        Panel_Joueur7.Visible = False
        Panel_Joueur8.Visible = False

        Select Case sender.value
            Case 3
                Panel_Joueur3.Visible = True
            Case 4
                Panel_Joueur3.Visible = True
                Panel_Joueur4.Visible = True
            Case 5
                Panel_Joueur3.Visible = True
                Panel_Joueur4.Visible = True
                Panel_Joueur5.Visible = True
            Case 6
                Panel_Joueur3.Visible = True
                Panel_Joueur4.Visible = True
                Panel_Joueur5.Visible = True
                Panel_Joueur6.Visible = True
            Case 7
                Panel_Joueur3.Visible = True
                Panel_Joueur4.Visible = True
                Panel_Joueur5.Visible = True
                Panel_Joueur6.Visible = True
                Panel_Joueur7.Visible = True
            Case 8
                Panel_Joueur3.Visible = True
                Panel_Joueur4.Visible = True
                Panel_Joueur5.Visible = True
                Panel_Joueur6.Visible = True
                Panel_Joueur7.Visible = True
                Panel_Joueur8.Visible = True
            Case Else
        End Select

    End Sub

    'Click sur le Bouton "Valider" (Panel_prepa)
    Private Sub BP_ValiderDep_Click(sender As Object, e As EventArgs) Handles BP_ValiderPrepa.Click
        Dim ligne As Integer

        If TB_Pseudo1.Text <> Nothing Then
            If TB_Pseudo2.Text <> Nothing Then
                If (NUD_NbrJoueurs.Value >= 3 And TB_Pseudo3.Text <> Nothing) Or NUD_NbrJoueurs.Value < 3 Then
                    If (NUD_NbrJoueurs.Value >= 4 And TB_Pseudo4.Text <> Nothing) Or NUD_NbrJoueurs.Value < 4 Then
                        If (NUD_NbrJoueurs.Value >= 5 And TB_Pseudo5.Text <> Nothing) Or NUD_NbrJoueurs.Value < 5 Then
                            If (NUD_NbrJoueurs.Value >= 6 And TB_Pseudo6.Text <> Nothing) Or NUD_NbrJoueurs.Value < 6 Then
                                If (NUD_NbrJoueurs.Value >= 7 And TB_Pseudo7.Text <> Nothing) Or NUD_NbrJoueurs.Value < 7 Then
                                    If (NUD_NbrJoueurs.Value >= 8 And TB_Pseudo8.Text <> Nothing) Or NUD_NbrJoueurs.Value < 8 Then


                                        'Suppression fichier TXT : IDJoueur.txt
                                        If File.Exists(cheminIDJoueurTXT) Then
                                            File.Delete(cheminIDJoueurTXT)
                                        End If

                                        'Suppression fichier TXT : Monopoly.txt
                                        If File.Exists(cheminMonopolyTXT) Then
                                            File.Delete(cheminMonopolyTXT)
                                        End If

                                        GestionFichier.FichierTXT.ExistePasLeCopie(cheminOriginal & "IDJoueur.txt", cheminIDJoueurTXT)
                                        GestionFichier.FichierTXT.ExistePasLeCopie(cheminOriginal & "Monopoly.txt", cheminMonopolyTXT)
                                        GestionFichier.FichierTXT.ExistePasLeCopie(cheminOriginal & "Indications.txt", cheminIndicationsTXT)



                                        'Ecriture des lancer de dé (normal)
                                        Dim lancé(0 To 35) As String
                                        lancé = ClassMD.GestionFichier.FichierTXT.ExisteLitTout(cheminLancerTXT)
                                        For i = 0 To 35
                                            Dé(i + 1, 0) = lancé(i)
                                        Next

                                        'Ecriture des lancer de dé (spécial)
                                        Dim lancéSpé(0 To 125) As String
                                        lancéSpé = ClassMD.GestionFichier.FichierTXT.ExisteLitTout(cheminLancerSpéTXT)
                                        For i = 0 To 125
                                            Dé(i + 1, 1) = lancéSpé(i)
                                        Next


                                        'Ecrire les montants de départ dans la variables montants()
                                        For ligne = 0 To NUD_NbrJoueurs.Value
                                            If ligne <> 0 Then
                                                montants(ligne) = Convert.ToInt32(TB_MontantDep.Text)
                                            End If
                                        Next




                                        'Ecriture des Pseudos des joueurs dans IDJoueur.txt
                                        Dim fichier As New System.IO.StreamWriter(cheminIDJoueurTXT)

                                        pseudo(0) = "Banque"
                                        pseudo(1) = TB_Pseudo1.Text
                                        pseudo(2) = TB_Pseudo2.Text
                                        pseudo(3) = TB_Pseudo3.Text
                                        pseudo(4) = TB_Pseudo4.Text
                                        pseudo(5) = TB_Pseudo5.Text
                                        pseudo(6) = TB_Pseudo6.Text
                                        pseudo(7) = TB_Pseudo7.Text
                                        pseudo(8) = TB_Pseudo8.Text

                                        For ligne = 0 To NUD_NbrJoueurs.Value
                                            fichier.WriteLine(pseudo(ligne))
                                        Next

                                        fichier.Close()

                                        ''Creation d'un fichier TXT nommé : pseudo.txt
                                        'For i = 1 To NUD_NbrJoueurs.Value
                                        '    Dim fichierPseudo As New System.IO.StreamWriter(cheminEXE & pseudo(i) & ".txt")
                                        '    fichierPseudo.WriteLine(i)
                                        '    fichierPseudo.Close()
                                        'Next





                                        'Choix aléatoire de la personne qui commence
                                        tour = lancer.Next(1, NUD_NbrJoueurs.Value)
                                        'Tour_suivant()
                                        Actualise_Indications(pseudo(tour) & " commence la partie !")



                                        'Ecriture de Monopoly.txt
                                        For ligne = 0 To NUD_NbrJoueurs.Value
                                            Monopoly(ligne, 0) = ligne
                                            Monopoly(ligne, 1) = pseudo(ligne)
                                            Monopoly(ligne, 2) = montants(ligne)
                                            Monopoly(ligne, 3) = cheminEXE & "Joueur" & ligne & ".txt"

                                            GestionFichier.FichierTXT.ExistePasLeCopie(cheminOriginal & "Joueur" & ligne & ".txt", Monopoly(ligne, 3))
                                            ActualiseJoueur(ligne, montants(ligne))
                                        Next



                                        'Pré-génération des dés
                                        Generation_dé(lancer.Next(1, 36), lancer.Next(1, 126))



                                        Panel_Prepa.Visible = False
                                        Panel_InGame.Visible = True
                                        'Panel_Plateau.Visible = True
                                        'Actualise_Jetons()
                                        Actualisation.Enabled = True

                                        'Me.MaximumSize = New Point(1180, 860)
                                        'Me.MinimumSize = New Point(1180, 860)
                                        'Me.Size = New Point(1180, 860)

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub





#End Region




#Region "Panel InGame"

    'Toutes les secondes, lecture du fichier : Monopoly.txt
    Private Sub Actualisation_Tick(sender As Object, e As EventArgs) Handles Actualisation.Tick



        'Déclaration des variables
        Dim captureflux As String
        Dim Donneur, Receveur As String
        Dim Montant, IDDonneur, IDReceveur As Integer
        Dim DonneurValide, ReceveurValide As Boolean


        'Init des variables
        DonneurValide = False
        ReceveurValide = False
        IDDonneur = 0
        IDReceveur = 0


        Try



            'Lecture du fichier txt
            Dim lecture As New StreamReader(cheminMonopolyTXT)
            captureflux = lecture.ReadLine
            lecture.Close()

            'Suppression fichier TXT : Monopoly.txt
            If File.Exists(cheminMonopolyTXT) Then
                File.Delete(cheminMonopolyTXT)
            End If

            'Remettre le fichier Monopoly.txt
            GestionFichier.FichierTXT.ExistePasLeCopie(cheminOriginal & "Monopoly.txt", cheminMonopolyTXT)

            'Traitement du transfert de fond
            If captureflux <> Nothing Then

                'Recuperation du Donneur, Receveur et Montant
                Donneur = Mid(captureflux, 1, captureflux.IndexOf("|"))
                captureflux = Mid(captureflux, Len(Donneur) + 2)

                Select Case Donneur


                'Lancement du dé normal
                    Case "D-"

                        'Récupération de la personne qui lance le dé
                        Receveur = captureflux

                        'Vérification du compte Receveur

                        If pseudo(tour) = Receveur Then
                            ReceveurValide = True
                        End If



                        If ReceveurValide Then

                            Select Case Dé_ligne1
                                Case 1, 8, 15, 22, 29, 36
                                    Actualise_Indications(pseudo(tour) & " rejoue !")
                                Case Else
                                    Tour_suivant()
                                    Actualise_Indications("C'est au tour de " & pseudo(tour) & " !")
                            End Select


                            'Génération de lancer de dé
                            Generation_dé(lancer.Next(1, 36), lancer.Next(1, 126))

                        End If




                    'Lancement du dé spécial
                    Case "D+"

                        'Récupération de la personne qui lance le dé
                        Receveur = captureflux

                        'Vérification du compte Receveur
                        For i = 0 To 8
                            If pseudo(i) = Receveur Then
                                ReceveurValide = True
                            End If
                        Next

                        If ReceveurValide Then

                            Select Case Dé_ligne2
                                Case 8, 15, 22, 29, 36, 37, 51, 58, 65, 72, 73, 80, 94, 101, 108, 109, 116, 123, 130, 137,
                                     144, 145, 152, 159, 166, 173, 180, 181, 188, 195, 202, 209, 216
                                    Actualise_Indications(pseudo(tour) & " rejoue !")
                                Case Else
                                    Tour_suivant()
                                    Actualise_Indications("C'est au tour de " & pseudo(tour) & " !")
                            End Select


                            'Génération de lancer de dé
                            Generation_dé(lancer.Next(1, 36), lancer.Next(1, 126))
                        End If



                        'Echange d'argent
                    Case Else
                        Receveur = Mid(captureflux, 1, captureflux.IndexOf("|"))
                        captureflux = Mid(captureflux, Len(Receveur) + 2)
                        Montant = Convert.ToInt32(captureflux)
                        LB_Flux.Text = Donneur & " _ " & Receveur & " _ " & Montant & "€"

                        'Vérification du compte Donneur
                        For i = 0 To 8
                            If pseudo(i) = Donneur Then
                                DonneurValide = True
                                IDDonneur = i
                            End If
                        Next

                        'Vérification du compte Receveur
                        For i = 0 To 8
                            If pseudo(i) = Receveur Then
                                ReceveurValide = True
                                IDReceveur = i
                            End If
                        Next

                        'Vérification que le Donneur et Receveur ne soit pas le même
                        If Donneur = Receveur Then
                            DonneurValide = False
                            ReceveurValide = False
                        End If

                        If DonneurValide And ReceveurValide Then
                            Dim NewMontant As Integer

                            'Donneur perd le montant donner
                            If IDDonneur <> 0 Then
                                NewMontant = Convert.ToInt32(Monopoly(IDDonneur, 2)) - Montant
                                Monopoly(IDDonneur, 2) = NewMontant
                                ActualiseJoueur(IDDonneur, NewMontant)
                            End If

                            'Receveur gagne le montant donner
                            If IDReceveur <> 0 Then
                                NewMontant = Convert.ToInt32(Monopoly(IDReceveur, 2)) + Montant
                                Monopoly(IDReceveur, 2) = NewMontant
                                ActualiseJoueur(IDReceveur, NewMontant)
                            End If


                        End If

                End Select

                'Actualisation.Enabled = False
            End If

            NbErreurs = 0

        Catch ex As Exception
            'Ne fait rien
            NbErreurs += 1

            If NbErreurs = 50 Then
                Actualise_Indications("PROBLEME DU LOGICIEL !!!")
            End If

        End Try

    End Sub


#End Region

End Class
