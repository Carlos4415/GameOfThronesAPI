// Este programa utiliza a API "Game of Thrones" para obter informações sobre um personagem específico,
// identificado pelo ID 583. O objetivo é realizar uma requisição HTTP para recuperar e exibir
// os recursos do personagem.
// A implementação faz uso da classe HttpClient para enviar a solicitação e processar a resposta,
// garantindo que os dados sejam tratados corretamente.
using(HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");
    Console.WriteLine(resposta);
}