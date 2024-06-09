# numeros-romanos

Escolhidas as implementações [1](./Codes/RomanNumerals1.cs) e [2](./Codes/RomanNumerals2.cs) submetidas na comunidade [Exercism](https://exercism.org/tracks/csharp/exercises/roman-numerals/solutions?page=1). Segue análise:

- Análise do primeiro código:

Define uma classe de extensão `RomanNumeralExtension` que adiciona um método de extensão `ToRoman` à classe `int`. 

A conversão é feita dividindo o número em milhares, centenas, dezenas e unidades, e então mapeando cada parte para sua representação romana correspondente.

No método `ToRoman`, o número é convertido em uma matriz de caracteres e dependendo do seu comprimento, o método acessa as funções `RomanUnits`, `RomanTens`, `RomanHundreds` e `RomanThousands` para obter a representação romana de cada parte do número.

- Análise do segundo código:

Semelhante ao código anterior, também define uma classe de extensão que adiciona um método de extensão `ToRoman` à classe `int`, porém, ao invés de realizar a conversão dígito por dígito, utiliza um dicionário `romans` que mapeia diretamente os valores numéricos para os símbolos romanos. A lógica do método `ToRoman` é então simplificada para iterar sobre o dicionário em ordem decrescente de valores numéricos e subtrair repetidamente o valor máximo possível de `value` enquanto constrói a representação romana.

# Conclusões

Considerando SOLID e Clean Code, o segundo código apresenta simplicidade, eficiência e maior facilidade de manutenção:
- Sendo mais simples e direto, ao utilizar um dicionário para mapear os valores numéricos para os símbolos romanos
- Eficiente pois não lida com cada dígito separadamente como o primeiro código
- Como consequência traz maior facilidade de manutenção pois um código simples e coeso é mais fácil de se manter e modificar.

