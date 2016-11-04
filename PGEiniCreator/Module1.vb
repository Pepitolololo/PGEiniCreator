Module Module1

    Sub Main()


        If (IO.File.Exists(AppPath & "offsets.ini")) = False Then

            Console.WriteLine("The offsets.ini file does not exist.")

        End If

        If (IO.File.Exists(AppPath & "function_offsets.ini")) = False Then

            Console.WriteLine("The function_offsets.ini file does not exist.")

        End If

        For Each Line As String In IO.File.ReadLines(AppPath & "offsets.ini")

            Dim splitstring As String() = Line.Split(New String() {" "}, StringSplitOptions.None)

            If Line.StartsWith("base_stats") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonData", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("poke_front_img") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonFrontSprites", splitstring(1).Remove(0, 2))
                WriteString(AppPath & "test.ini", "BPEE", "PokemonAnimations", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("poke_back_img") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonBackSprites", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("poke_sprite_pal") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonNormalPal", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("shiny_sprite_pal") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonShinyPal", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("icon_img") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "IconPointerTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("icon_pal") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "IconPalTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("poke_names") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonNames", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("tm_hm_comp_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "TMHMCompatibility", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("move_tutor_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "MoveTutorCompatibility", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("dex_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokedexData", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("evo_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonEvolutions", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("enymyyTable") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "EnemyYTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("playeryTable") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PlayerYTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("learnset_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokemonAttackTable", splitstring(1).Remove(0, 2))
                'ElseIf Line.StartsWith("front_animation_table") = True Then
                '    WriteString(AppPath & "test.ini", "BPEE", "PokemonAnimations", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("footprint_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "FootPrintTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("crytable1") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "CryTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("crytable2") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "CryTable2", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("altitude_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "EnemyAltitudeTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("auxialary_cry_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "CryConversionTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("AllPokes") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NumberOfPokemon", splitstring(1))
            ElseIf Line.StartsWith("NationalDexPokes") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NumberOfDexEntries", splitstring(1) + 1)
            ElseIf Line.StartsWith("RegionalDexPokes") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NumberOfRegionDex", splitstring(1) + 1)
            ElseIf Line.StartsWith("nationaldex_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NationalDexTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("hoenn_dex_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "SecondDexTable", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("hoenn_to_national_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "HoenntoNationalDex", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("item_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "ItemData", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("item_images") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "ItemIMGData", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("TM_compatibility_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "TMHMCompatibility", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("MoveTutor_compatibility_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "MoveTutorCompatibility", splitstring(1).Remove(0, 2))
            ElseIf Line.StartsWith("ItemsNo") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NumberOfItems", splitstring(1) + 1)
            ElseIf Line.StartsWith("TutorMoves") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "NumberOfMoveTutorAttacks", splitstring(1))
            ElseIf Line.StartsWith("TMsNo") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "TotalTMs", splitstring(1))
            ElseIf Line.StartsWith("TMs+HMs") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "TotalTMsPlusHMs", splitstring(1))
            End If
        Next

        For Each Line As String In IO.File.ReadLines(AppPath & "function_offsets.ini")

            Dim splitstring2 As String() = Line.Split(New String() {" "}, StringSplitOptions.None)

            If Line.StartsWith("a_to_z_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokedexAlphabetTable", splitstring2(24).Remove(0, 2))
            ElseIf Line.StartsWith("lightest_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokedexLightestTable", splitstring2(22).Remove(0, 2))
            ElseIf Line.StartsWith("smallest_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "PokedexSmallestTable", splitstring2(22).Remove(0, 2))
            ElseIf Line.StartsWith("TM_move_table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "TMData", splitstring2(14).Remove(0, 2))
            ElseIf Line.StartsWith("Tutor_Move_Table") = True Then
                WriteString(AppPath & "test.ini", "BPEE", "MoveTutorAttacks", splitstring2(11).Remove(0, 2))
            End If

        Next

    End Sub

End Module
