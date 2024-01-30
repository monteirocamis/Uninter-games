#inicio
print("------------------------------------------------------")
print("Bem vindo ao exercicio 2 da Camila Monteiro Chaves!")
print("------------------------------------------------------")

#sabor
sabor = input("Digite o sabor CP para Cupuaçu ou AC para açai: ")
# Acumulador para somar os valores dos pedidos
total = 0

#verifica sabor invalido
while sabor not in ("CP", "AC"):
   print("Sabor inválido.  ")
   sabor = input("Digite CP ou AC:")

tamanho = input("Digite o tamanho P para pequeno, M para médio ou G para grande: ")
while tamanho not in ("P", "M", "G"):
   print("Tamanho inválido.")
   tamanho = input("Digite P, M ou G : ")



# valores cupuaçu
if sabor == "CP":
   # Tamanho P de Cupuaçu (CP) custa 10 reais 
   if tamanho == "P":
       valor = 10
    # Tamanho M de Cupuaçu (CP) custa 15 reais 
   elif tamanho == "M":
       valor = 15
    # Tamanho G de Cupuaçu (CP) custa 19 reais e o Açaí (AC) custa 21 reais;
   else:
       valor = 19

else:
    # Tamanho P de Açaí (AC) custa 12 reais;
   if tamanho == "P":
       valor = 12
    # Tamanho M de Açaí (AC) custa 17 reais;
   elif tamanho == "M":
       valor = 17
    # Tamanho G de Açaí (AC) custa 21 reais;
   else:
       valor = 21

total = valor

# conferir se adiciona mais
pedido = input("Deseja pedir mais alguma coisa? (S/N): ")

while pedido == "S":
  
    #sabor
    sabor = input("Digite o sabor CP para Cupuaçu ou AC para açai: ")

    #verifica sabor invalido
    while sabor not in ("CP", "AC"):
        print("Sabor inválido.  ")
        sabor = input("Digite CP ou AC:")

    tamanho = input("Digite o tamanho P para pequeno, M para médio ou G para grande: ")
    while tamanho not in ("P", "M", "G"):
        print("Tamanho inválido.")
        tamanho = input("Digite P, M ou G : ")



    # valores cupuaçu
    if sabor == "CP":
        # Tamanho P de Cupuaçu (CP) custa 10 reais 
        if tamanho == "P":
            valor = 10
            # Tamanho M de Cupuaçu (CP) custa 15 reais 
        elif tamanho == "M":
            valor = 15   
            # Tamanho G de Cupuaçu (CP) custa 19 reais e o Açaí (AC) custa 21 reais;
        else:
            valor = 19

    else:
        # Tamanho P de Açaí (AC) custa 12 reais;
        if tamanho == "P":
            valor = 12
            # Tamanho M de Açaí (AC) custa 17 reais;
        elif tamanho == "M":
            valor = 17
            # Tamanho G de Açaí (AC) custa 21 reais;
        else:
            valor = 21

    # somar valores
    total += valor

   # confere 
pedido = input("Deseja inserir mais itens? (S/N): ")

# resultado do pedid o
print("Total: R$", total)

