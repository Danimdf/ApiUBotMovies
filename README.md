# ApiUBotMovies
Api de filmes feita em Asp.Net para resolução de teste para Estágio da empresa Ubot.

O que faltou implentar?\
O sistema de Avaliação e a verificação. 

Como imagino que seja a Solução?\
Criação de uma tabela filha de filmes, chamada avaliação, nesta tabela haveria as notas de 1 á 5. Para diferenciar entre os filmes assistidos ou não, havera um bool em AppDbContext que dará false naqueles filmes não vistos, levando para uma lista de não avaliados.
