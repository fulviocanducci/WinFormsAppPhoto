Imports System.IO
Imports System.Net.Http

Public Class Form1
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'Direto pela URL
      Dim myUrl As String = "https://masterescola.nyc3.digitaloceanspaces.com/clientes/colegiojp/fotos/2008/05/038_81535bfAJhRV.png"
      PictureBox1.Load(myUrl)

      'Requisição Web Transformando em Imagem localmente
      Dim client = New HttpClient()
      Try
         Dim result As Byte() = client.GetByteArrayAsync(myUrl).Result
         Dim name As String = Application.StartupPath & "/" & Guid.NewGuid().ToString() + ".png"
         File.WriteAllBytes(name, result)
         client?.Dispose()
         PictureBox2.Image = Image.FromFile(name)
      Catch ex As Exception

      Finally
         client?.Dispose()
      End Try
   End Sub
End Class
