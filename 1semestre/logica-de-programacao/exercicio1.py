# inicio
print("------------------------------------------------------")
print("Olá, Essa é a entrega da aluna Camila Monteiro Chaves.")
print("------------------------------------------------------")

#dados
valor = float(input("Insira o valor do produto: "))
quantidade = int(input("Insira a quantidade: "))
desconto = 0

#calculo de valor com desconto
totalSemDesconto = valor * quantidade

#menor que 1000 o desconto será de 0%;
if quantidade < 1000 :
   desconto = 0

# igual ou maior que 1000 e menor que 3000 o desconto será de 3%;
elif quantidade < 3000:
   desconto = 3

# igual ou maior que 3000 e menor que 5000 o desconto será de 5%
elif quantidade < 5000:
   desconto = 5

# igual ou maior que 5000 o desconto será de 8%;
else:
   desconto = 8



# calculo do valor com desconto
totalComDesconto = totalSemDesconto - (valor * desconto / 100)

# resultados

print("O valor SEM desconto é R$ {:.2f}.".format(totalSemDesconto))
print("-------------------------------------------")
print("Você teve ", desconto,"% de desconto.")
print(" Seu valor COM desconto é de R$ {:.2f}.".format(totalComDesconto))
print("-------------------------------------------")