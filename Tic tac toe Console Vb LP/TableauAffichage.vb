Public Class TableauAffichage

    'int pour compter le nombre de case prise total
    Dim CasePriseTotal As Integer = 0

    'int pour bloquer case si pris
    Dim CaseBloquer1 As Boolean = False
    Dim CaseBloquer2 As Boolean = False
    Dim CaseBloquer3 As Boolean = False
    Dim CaseBloquer4 As Boolean = False
    Dim CaseBloquer5 As Boolean = False
    Dim CaseBloquer6 As Boolean = False
    Dim CaseBloquer7 As Boolean = False
    Dim CaseBloquer8 As Boolean = False
    Dim CaseBloquer9 As Boolean = False


    Dim CaseNombre(10) As String
    Public Sub New()
        CaseNombre = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    End Sub





    Public Sub Tableau()
        Console.WriteLine($"     |     |     ")
        Console.WriteLine("  {0}  |  {1}  |  {2}", CaseNombre(1), CaseNombre(2), CaseNombre(3))
        Console.WriteLine($"_____|_____|_____")
        Console.WriteLine($"     |     |     ")
        Console.WriteLine("  {0}  |  {1}  |  {2}", CaseNombre(4), CaseNombre(5), CaseNombre(6))
        Console.WriteLine($"_____|_____|_____")
        Console.WriteLine($"     |     |     ")
        Console.WriteLine("  {0}  |  {1}  |  {2}", CaseNombre(7), CaseNombre(8), CaseNombre(9))
        Console.WriteLine($"     |     |     ")
    End Sub


    'boolean pour redonner tour si choix déja prit
    Public ChoixJoueur1DejaPrit As Boolean
    Public ChoixJoueur2DejaPrit As Boolean
    Public Sub ChangerSymboleTableau(NumeroCase As Integer, SymboleCase As String, NumeroJoueur As Integer)
        Select Case NumeroCase
            Case 1

                If CaseBloquer1 = False Then
                    CaseNombre(1) = SymboleCase
                    CaseBloquer1 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 2
                If CaseBloquer2 = False Then
                    CaseNombre(2) = SymboleCase
                    CaseBloquer2 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 3
                If CaseBloquer3 = False Then
                    CaseNombre(3) = SymboleCase
                    CaseBloquer3 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 4
                If CaseBloquer4 = False Then
                    CaseNombre(4) = SymboleCase
                    CaseBloquer4 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 5
                If CaseBloquer5 = False Then
                    CaseNombre(5) = SymboleCase
                    CaseBloquer5 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 6
                If CaseBloquer6 = False Then
                    CaseNombre(6) = SymboleCase
                    CaseBloquer6 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 7
                If CaseBloquer7 = False Then
                    CaseNombre(7) = SymboleCase
                    CaseBloquer7 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 8
                If CaseBloquer8 = False Then
                    CaseNombre(8) = SymboleCase
                    CaseBloquer8 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If

            Case 9
                If CaseBloquer9 = False Then
                    CaseNombre(9) = SymboleCase
                    CaseBloquer9 = True
                    CasePriseTotal += 1
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = True
                    Else
                        ChoixJoueur2DejaPrit = True
                    End If
                Else
                    Console.WriteLine("la case est déjà prise")
                    If NumeroJoueur = 1 Then
                        ChoixJoueur1DejaPrit = False
                    Else
                        ChoixJoueur2DejaPrit = False
                    End If
                End If


        End Select

    End Sub

    Sub ConditionVictoireRegarder() 'condition de victoire a ameliorer car degueulasse

        If (CaseNombre(1) = "X" And CaseNombre(2) = "X" And CaseNombre(3) = "X") Or (CaseNombre(4) = "X" And CaseNombre(5) = "X" And CaseNombre(6) = "X") Or (CaseNombre(7) = "X" And CaseNombre(8) = "X" And CaseNombre(9) = "X") Or (CaseNombre(1) = "X" And CaseNombre(4) = "X" And CaseNombre(7) = "X") Or (CaseNombre(2) = "X" And CaseNombre(5) = "X" And CaseNombre(8) = "X") Or (CaseNombre(3) = "X" And CaseNombre(6) = "X" And CaseNombre(9) = "X") Or (CaseNombre(1) = "X" And CaseNombre(5) = "X" And CaseNombre(9) = "X") Or (CaseNombre(3) = "X" And CaseNombre(5) = "X" And CaseNombre(7) = "X") Then

            Module1.ConditionDeVictoire = True
            Module1.ScoreJoueurUn += 1
            Module1.JoueurVictoire1 = True
        ElseIf (CaseNombre(1) = "O" And CaseNombre(2) = "O" And CaseNombre(3) = "O") Or (CaseNombre(4) = "O" And CaseNombre(5) = "O" And CaseNombre(6) = "O") Or (CaseNombre(7) = "O" And CaseNombre(8) = "O" And CaseNombre(9) = "O") Or (CaseNombre(1) = "O" And CaseNombre(4) = "O" And CaseNombre(7) = "O") Or (CaseNombre(2) = "O" And CaseNombre(5) = "O" And CaseNombre(8) = "O") Or (CaseNombre(3) = "O" And CaseNombre(6) = "O" And CaseNombre(9) = "O") Or (CaseNombre(1) = "O" And CaseNombre(5) = "O" And CaseNombre(9) = "O") Or (CaseNombre(3) = "O" And CaseNombre(5) = "O" And CaseNombre(7) = "O") Then

            Module1.ConditionDeVictoire = True
            Module1.ScoreJoueurDeux += 1
            Module1.JoueurVictoire2 = True

        ElseIf CasePriseTotal = 9 Then
            Module1.MatchNullBool = True
        End If




    End Sub
End Class
