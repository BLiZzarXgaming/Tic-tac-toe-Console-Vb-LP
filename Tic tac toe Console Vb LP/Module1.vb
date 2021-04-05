Module Module1
    Public ConditionDeVictoire As Boolean = False
    Public ScoreJoueurUn As Integer = 0
    Public ScoreJoueurDeux As Integer = 0
    Public MatchNullBool As Boolean
    Public JoueurVictoire1 As Boolean
    Public JoueurVictoire2 As Boolean
    Sub Main()

        Dim NomJoueur1 As String
        Dim NomJoueur2 As String


        Console.WriteLine("Bienvenue sur le jeu Tic Tac Toe de LP!!!")
        Console.WriteLine("Pour commencer, je vais prendre vos nom")
        Console.WriteLine("Joueur 1 taper votre nom:")

        'choix nom joueur 1
        Dim NomJoueur1ValidationNom As Boolean = False
        Do Until NomJoueur1ValidationNom = True
            NomJoueur1 = Console.ReadLine()
            Console.WriteLine("Votre nom est: " & NomJoueur1)
            Console.WriteLine("Est-ce correct? si oui taper o sinon sur n")
            Dim reponseutilisateur As String = Console.ReadLine()
            If reponseutilisateur = "o" Then
                NomJoueur1ValidationNom = True
            ElseIf reponseutilisateur = "n" Then
                Console.WriteLine("réécrit le!")
            Else
                Console.WriteLine("ce n'est pas dans les choix! recommence")
            End If


        Loop

        'choix nom joueur 2
        Console.WriteLine("Joueur 2 taper votre nom:")
        Dim NomJoueur2ValidationNom As Boolean = False
        Do Until NomJoueur2ValidationNom = True
            NomJoueur2 = Console.ReadLine()
            Console.WriteLine("Votre nom est: " & NomJoueur2)
            Console.WriteLine("Est-ce correct? si oui taper o sinon sur n")
            Dim reponseutilisateur As String = Console.ReadLine()
            If reponseutilisateur = "o" Then
                NomJoueur2ValidationNom = True
            ElseIf reponseutilisateur = "n" Then
                Console.WriteLine("réécrit le!")
            Else
                Console.WriteLine("ce n'est pas dans les choix! recommence")
            End If


        Loop



        Do Until ConditionDeVictoire = True

            Dim ContinuerJeu As Boolean = True

            Dim TableauAffichage As New TableauAffichage()

            Dim TourJoueurUN As Boolean = True


            Dim TourJoueurDeux As Boolean = False

            'boucle du jeu
            Do While ContinuerJeu = True
                TableauAffichage.Tableau()
                Dim ReponseJoueur As String
                Dim ReponseValide As Boolean
                ReponseValide = False

                'boucle joueur un
                Do While TourJoueurUN = True
                    ReponseValide = False
                    ReponseJoueur = vbEmpty
                    If TourJoueurUN = True Then
                        Console.WriteLine("C'est au tour de " & NomJoueur1 & " de jouer")
                        Console.WriteLine("Veuillez écrire le numéro de la case choisi")

                        Do Until ReponseValide = True
                            ReponseJoueur = vbEmpty
                            ReponseJoueur = Console.ReadLine()

                            If ReponseJoueur = "1" Or ReponseJoueur = "2" Or ReponseJoueur = "3" Or ReponseJoueur = "4" Or ReponseJoueur = "5" Or ReponseJoueur = "6" Or ReponseJoueur = "7" Or ReponseJoueur = "8" Or ReponseJoueur = "9" Then
                                TableauAffichage.ChangerSymboleTableau(Convert.ToInt32(ReponseJoueur), "X", 1)
                                If TableauAffichage.ChoixJoueur1DejaPrit = True Then
                                    TourJoueurUN = False
                                    ReponseValide = True
                                    TourJoueurDeux = True
                                    TableauAffichage.ChoixJoueur1DejaPrit = False
                                End If
                                TableauAffichage.ChoixJoueur1DejaPrit = True
                            Else
                                Console.WriteLine("DSl le choix n'est pas correct recommence:")
                            End If
                        Loop

                    End If
                    TableauAffichage.ConditionVictoireRegarder()
                    If ConditionDeVictoire = True Then
                        TourJoueurDeux = False
                        ContinuerJeu = False
                    End If
                Loop 'fin boucle joueur un

                TableauAffichage.Tableau()

                'boucle joueur deux
                Do While TourJoueurDeux = True
                    ReponseValide = False
                    ReponseJoueur = vbEmpty
                    If TourJoueurUN = False Then
                        Console.WriteLine("C'est au tour de " & NomJoueur2 & " de jouer")
                        Console.WriteLine("Veuillez écrire le numéro de la case choisi")

                        Do Until ReponseValide = True
                            ReponseJoueur = vbEmpty
                            ReponseJoueur = Console.ReadLine()

                            If ReponseJoueur = "1" Or ReponseJoueur = "2" Or ReponseJoueur = "3" Or ReponseJoueur = "4" Or ReponseJoueur = "5" Or ReponseJoueur = "6" Or ReponseJoueur = "7" Or ReponseJoueur = "8" Or ReponseJoueur = "9" Then
                                TableauAffichage.ChangerSymboleTableau(Convert.ToInt32(ReponseJoueur), "O", 2)
                                If TableauAffichage.ChoixJoueur2DejaPrit = True Then
                                    TourJoueurUN = True
                                    ReponseValide = True
                                    TourJoueurDeux = False
                                    TableauAffichage.ChoixJoueur2DejaPrit = False
                                End If
                                TableauAffichage.ChoixJoueur2DejaPrit = True
                            Else
                                Console.WriteLine("DSl le choix n'est pas correct recommence:")
                            End If
                        Loop

                    End If
                    TableauAffichage.ConditionVictoireRegarder()
                    If ConditionDeVictoire = True Then

                        ContinuerJeu = False
                    End If
                Loop ' fin boucle joueur deux

            Loop 'fin boucle jeu joueur chooisi



            If MatchNullBool = True Then
                Console.WriteLine("match nulle :(")
            ElseIf JoueurVictoire1 = True Then
                Console.WriteLine(NomJoueur1 & " à gagné!!! ")
            Else
                Console.WriteLine(NomJoueur2 & " à gagné!!! ")

            End If

            Console.WriteLine("Voici les scores")
            Console.WriteLine(NomJoueur1 & ":   " & ScoreJoueurUn.ToString(ScoreJoueurUn))
            Console.WriteLine(NomJoueur2 & ": " & ScoreJoueurDeux.ToString(ScoreJoueurDeux))
            Console.WriteLine("Voulez-vous continuer?")
            Console.WriteLine("Si oui peser sur o sinon peser sur n")

            Dim ReponsePourContinuerLeJeu As String = ""

            Do Until ReponsePourContinuerLeJeu = "o" Or ReponsePourContinuerLeJeu = "n"
                ReponsePourContinuerLeJeu = vbEmpty
                ReponsePourContinuerLeJeu = Console.ReadLine()
                If ReponsePourContinuerLeJeu = "o" Or ReponsePourContinuerLeJeu = "n" Then
                Else
                    Console.WriteLine("le charactere n'est pas valide recommence")
                End If
            Loop

            If ReponsePourContinuerLeJeu = "o" Then
                ConditionDeVictoire = False
                TourJoueurUN = True
                TourJoueurDeux = False
                JoueurVictoire1 = False
                JoueurVictoire2 = False
            Else
                Console.WriteLine("Dommage :( bonne journée!")
                Console.WriteLine("Peser sur enter pour quitter")
                Console.ReadLine()
            End If

        Loop ' fin boucle condition de victoire
    End Sub

End Module
