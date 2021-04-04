Module Module1
    Public ConditionDeVictoire As Boolean = False
    Public ScoreJoueurUn As Integer = 0
    Public ScoreJoueurDeux As Integer = 0
    Public MatchNullBool As Boolean
    Public JoueurVictoire1 As Boolean
    Public JoueurVictoire2 As Boolean
    Sub Main()


        Do Until ConditionDeVictoire = True

            Dim ContinuerJeu As Boolean = True

            Dim TableauAffichage As New TableauAffichage()

            Dim TourJoueurUN As Boolean = True


            Dim TourJoueurDeux As Boolean = False

            'boucle du jeu
            Do While ContinuerJeu = True
                TableauAffichage.Tableau()
                Dim ReponseJoueur As Integer
                Dim ReponseValide As Boolean
                ReponseValide = False

                'boucle joueur un
                Do While TourJoueurUN = True
                    ReponseValide = False
                    ReponseJoueur = vbEmpty
                    If TourJoueurUN = True Then
                        Console.WriteLine("C'est au tour du joueur 1 de jouer")
                        Console.WriteLine("Veuillez écrire le numéro de la case choisi")

                        Do Until ReponseValide = True
                            ReponseJoueur = vbEmpty
                            ReponseJoueur = Console.ReadLine()

                            If ReponseJoueur = 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Then
                                TableauAffichage.ChangerSymboleTableau(ReponseJoueur, "X", 1)
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
                        Console.WriteLine("C'est au tour du joueur 2 de jouer")
                        Console.WriteLine("Veuillez écrire le numéro de la case choisi")

                        Do Until ReponseValide = True
                            ReponseJoueur = vbEmpty
                            ReponseJoueur = Console.ReadLine()

                            If ReponseJoueur = 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9 Then
                                TableauAffichage.ChangerSymboleTableau(ReponseJoueur, "O", 2)
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
                Console.WriteLine("Le joueur 1 à gagné!!! ")
            Else
                Console.WriteLine("Le joueur 2 à gagné!!! ")

            End If

            Console.WriteLine("Voici les scores")
            Console.WriteLine("Joueur 1: " + ScoreJoueurUn.ToString(ScoreJoueurUn))
            Console.WriteLine("Joueur 2: " + ScoreJoueurDeux.ToString(ScoreJoueurDeux))
            Console.WriteLine("Voulez-vous continuer?")
            Console.WriteLine("Si oui peser sur o sinon peser sur n")

            Dim ReponsePourContinuerLeJeu As String = ""
            ReponsePourContinuerLeJeu = Console.ReadLine()
            Do Until ReponsePourContinuerLeJeu = "o" Or ReponsePourContinuerLeJeu = "n"
                ReponsePourContinuerLeJeu = vbEmpty
                ReponsePourContinuerLeJeu = Console.ReadLine()
                If ReponsePourContinuerLeJeu = "o" Or "n" Then
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
