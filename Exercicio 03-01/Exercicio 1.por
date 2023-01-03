programa
{
	real quilometroRodado, litrosAbastecido,consumoMedio
	
	funcao inicio()
	{
		receberValores()
		logico valoresPositivos = validarDados()
		enquanto(valoresPositivos==falso){
			receberValores()
			valoresPositivos=validarDados()
		}
		mediaConsumo()
		
	}
	funcao receberValores(){
		escreva("\nPor favor digite a quantidade de Quilometros Rodado: ")
		leia(quilometroRodado)
		escreva("\nPor favor digite a quantidade de Litos Abastecidos: ")
		leia(litrosAbastecido)
	}
	funcao logico validarDados(){
		enquanto(quilometroRodado<=0)
		{
			escreva("Não pode ter Quilometro negativo ou igual a 0")
			retorne falso
		}
		enquanto(litrosAbastecido<=0)
		{
			escreva("Não pode ter abastecimento negativo ou igual a 0")
			retorne falso
		}
		retorne verdadeiro
	}
	funcao mediaConsumo(){
		consumoMedio=quilometroRodado/litrosAbastecido
		escreva("\n A media do veiculo é: "+consumoMedio)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 266; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */