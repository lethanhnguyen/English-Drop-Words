Public Class Form1
    Dim stopWords As String() = {"a", "about", "above", "after", "again", "against", "all", "am", "an", "And", "any", "are", "aren't", "as", "at", "be", "because", "been", "before", "being", "below", "between", "both", "but", "by", "can't", "cannot", "could", "couldn't", "did", "didn't", "Do", "does", "doesn't", "doing", "don't", "down", "during", "each", "few", "For ", "from", "further", "had", "hadn't", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her", "here", "here's", "hers", "herself", "him", "himsel", "his", "how", "how's", "i", "i'd", "i'll", "i'm", "i've", "If ", "in", "into", "Is", "isn't", "it", "it's", "its", "itself", "let's", "Me", "more", "most", "mustn't", "my", "myself", "no", "nor", "Not", "of", "off", "On", "once", "only", "Or", "other", "ought", "our", "ours", "ourselves", "out", "over", "own", "same", "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than", "that", "that's", "the", "their", "theirs", "them", "themselves", "then", "there", "there's", "these", "they", "they'd", "they'll", "they're", "they've", "this", "those", "through", "to", "too", "under", "until", "up", "very", "was", "wasn't", "we", "we'd", "we'll", "we're", "we've", "were", "weren't", "what", "what's", "when", "when's", "where", "where's", "which", "While ", "who", "who's", "whom", "why", "why's", "With ", "won't", "would", "wouldn't", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves"}

    Private Sub btnPreprocessing_Click(sender As Object, e As EventArgs) Handles btnPreprocessing.Click
        Dim textOriginal As String = txtOriginalText.Text
        textOriginal = textOriginal.Replace(vbTab, " ")
        'txtOriginalText.Text = textOriginal
        'Dim textOriginalArr As String() = textOriginal.Split(CChar(vbCrLf))
        Dim strLines As String() = textOriginal.Split(New String() {Convert.ToChar(13), Convert.ToChar(10)}, StringSplitOptions.RemoveEmptyEntries)
        Debug.Print(strLines.Count)
        textOriginal = ""
        For i As Integer = 0 To strLines.Count - 2
            If strLines(i).Trim().EndsWith(".") Or strLines(i).Trim().EndsWith("?") Or strLines(i).Trim().EndsWith("!") Or IsUpperCase(strLines(i + 1).Trim().ElementAt(0)) = True Then
                textOriginal = textOriginal + strLines(i) + vbNewLine
            Else
                textOriginal = textOriginal + strLines(i) + " "
            End If
        Next
        textOriginal = textOriginal + strLines(strLines.Count - 1)

        txtOriginalText.Text = textOriginal
    End Sub

    Public Function IsUpperCase(inputChar As Char) As Boolean
        Return inputChar >= "A"c AndAlso inputChar <= "Z"c
    End Function

    Private Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click
        txtDroppedText.Text = ""
        Dim textOriginal As String = txtOriginalText.Text
        Dim strLines As String() = textOriginal.Split(New String() {Convert.ToChar(13), Convert.ToChar(10)}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To strLines.Count - 1
            Dim sentence As String = strLines(i)
            sentence = sentence.Replace(".", " . ")
            sentence = sentence.Replace("!", " ! ")
            sentence = sentence.Replace("?", " ? ")
            sentence = sentence.Replace("  ", " ")
            Dim words As String() = sentence.Trim().Split(" ")

            Dim numToRemove As Integer = words.Count * numDropRatio.Value / 100
            Debug.Print(sentence)
            Debug.Print(numToRemove)
            Dim newSentence As String = ""
            Dim preWordIsStopword As Boolean = False
            For j As Integer = 0 To words.Count - 1
                Debug.Print(words(j))
                If isStopWord(words(j)) = False Then
                    'kg la stopword
                    If cbDrop2Words.Checked = False Then
                        Debug.Print("turn off drop")
                        'kg the drop 2 tu lien tiep
                        If preWordIsStopword = False Then
                            Debug.Print("before not drop")
                            'neu tu phia truoc chua drop
                            If numToRemove > 0 Then
                                Dim value As Integer = CInt(Int((2 * Rnd()) + 1))

                                If value = 1 Then
                                    Debug.Print("drop")
                                    newSentence = newSentence + " ______________"
                                    preWordIsStopword = True
                                    numToRemove = numToRemove - 1
                                Else
                                    Debug.Print("not drop")
                                    newSentence = newSentence + " " + words(j)
                                End If
                            Else
                                Debug.Print("not drop")
                                newSentence = newSentence + " " + words(j)
                            End If
                        Else
                            'neu da drop roi thi bo qua
                            Debug.Print("before drop")
                            newSentence = newSentence + " " + words(j)
                            preWordIsStopword = False
                        End If
                    Else
                        Debug.Print("turn on drop")
                        'co the drop 2 tu lien tiep
                        If numToRemove > 0 Then
                            'replace
                            Dim value As Integer = CInt(Int((2 * Rnd()) + 1))

                            If value = 1 Then
                                newSentence = newSentence + " ______________"
                                numToRemove = numToRemove - 1
                            Else
                                newSentence = newSentence + " " + words(j)
                            End If
                        Else
                            newSentence = newSentence + " " + words(j)
                        End If
                    End If
                Else
                    'stopword
                    Debug.Print("is stopword")
                    newSentence = newSentence + " " + words(j)
                End If
            Next

            txtDroppedText.Text = txtDroppedText.Text + newSentence.Trim() + vbNewLine
        Next
    End Sub

    Private Function isStopWord(word As String)
        'Debug.Print("word = " + word)
        If word.Trim() = "" Then
            Return False
        End If

        If word.Trim() = "." Or word.Trim() = "?" Or word.Trim() = "!" Then
            Return True
        End If

        If cbDropCapitalWords.Checked = True And IsUpperCase(word.ElementAt(0)) = True Then
            Return True
        Else
            For i As Integer = 0 To stopWords.Count - 1
                If stopWords(i).ToLower = word.ToLower Then
                    Return True
                End If
            Next
        End If

        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(txtDroppedText.Text)
    End Sub
End Class
