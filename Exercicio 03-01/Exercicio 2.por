programa
{
	real distanciaDisponivel, litrosAbastecido,consumoMedio
	
	funcao inicio()
	{
		receberValores()
		logico valoresPositivos = validarDados()
		enquanto(valoresPositivos==falso){
			receberValores()
			valoresPositivos=validarDados()
		}
		autonomiaVeiculo()
		
	}
	funcao receberValores(){
		escreva("\nPor favor digite a quantidade de Litros no Veiculo: ")
		leia(litrosAbastecido)
		escreva("\nPor favor digite o Consumo medio do Veiculo: ")
		leia(consumoMedio)
	}
	funcao logico validarDados(){
		enquanto(consumoMedio<=0)
		{
			escreva("Não pode ter Consumo negativo ou igual a 0")
			retorne falso
		}
		enquanto(litrosAbastecido<=0)
		{
			escreva("Não pode ter abastecimento negativo ou igual a 0")
			retorne falso
		}
		retorne verdadeiro
	}
	funcao autonomiaVeiculo(){
		distanciaDisponivel=litrosAbastecido*consumoMedio
		escreva("\n Este Veiculo pode percorrer: "+distanciaDisponivel+"Km")
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 574; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */