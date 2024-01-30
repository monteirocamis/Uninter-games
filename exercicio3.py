

def escolha_servico():
   while True:
       servico = input('Escolha o serviço desejado: \n' +

                       'DIG - Digitalização \n' +

                       'ICO - Impressão Colorida \n' +

                       'IPB - Impressão Preto e Branco \n' +

                       'FOT - Fotocópia \n'

                       '>>:') .upper()

       if servico in ["DIG", "ICO", "IBO", "FOT"]:
           return servico
       else:
           print("Opção de serviço inválida. Tente novamente.")


# calcular o número de páginas com desconto
def num_pagina_com_desconto():
   while True:
       try:
           num_paginas = int(input("Digite o número de páginas: "))
           if num_paginas < 10:
               return  num_paginas
           elif 10 <= num_paginas < 100:
               return num_paginas * 0.9 # Desconto de 10%
           elif 100 <= num_paginas < 1000:
               return  num_paginas * 0.85 # Desconto de 15%
           else:
               print("Número de páginas não permitido. Tente novamente.")
       except ValueError:
           print("Por favor, insira um valor numérico válido.")




# servicos extras
def servico_extra():
   valor_extra = 0
   while True:
       servico_adicional = input('Escolha o serviço adicional: \n' +

                                 '1 - Encadernação Simples \n' +

                                 '2 - Encadernação Capa Dura \n' +

                                 '0 - Não desejo mais nada \n' +

                                 '>>:')

       if servico_adicional == "1":
           valor_extra += 10
       elif servico_adicional == "2":
           valor_extra += 25
       elif servico_adicional == "0":
           return valor_extra
       else:
           print("Opção de serviço adicional inválida. Tente novamente.")



# resultado do pedido
def mostrar_resumo(servico, num_paginas, valor_extra):
   print("\n ------------------")
   print("Resumo do Pedido:")
   print(" ------------------ \n")
   print(f"Serviço escolhido: {servico}")
   print(f"Número de páginas com desconto: {num_paginas:.0f}")
   print(f"Valor dos serviços extras: R$ {valor_extra:.2f}")



# função principal
def main():
   print("\n------------------------------------------------------- ")
   print("Bem-vindo ao Exercicio 3 da Camila Monteiro chaves.")
   print("------------------------------------------------------- \n ")
   try:
       servico = escolha_servico()
       num_paginas = num_pagina_com_desconto()
       valor_extra = servico_extra()
       servico_preco = {"DIG": 1.10, "ICO": 1.00, "IBO": 0.40, "FOT": 0.20}
       total = servico_preco[servico] * num_paginas + valor_extra
       print(f"Total a pagar: R$ {total:.2f}")
       mostrar_resumo(servico, num_paginas, valor_extra)

   except KeyboardInterrupt:
       print("\nOperação interrompida pelo usuário.")
   except Exception as e:
       print(f"Erro: {e}")

if __name__ == "__main__":
   main()

