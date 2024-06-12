programa {
  funcao inicio() {
    inteiro n
    
    escreva("Quantos números você deseja digitar? ")
    leia(n)
   
    inteiro vetor[n]
    para(inteiro i = 0 ; i < n; i++){
escreva("Digite um número: ")
leia(vetor[i])
    }

escreva("\nNúmeros Negativos: \n")
    para(inteiro i = 0; i < n ; i++){
se(vetor[i]<0){
escreva(vetor[i],"\n")
}
    }
  }
}
