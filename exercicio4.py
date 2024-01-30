# Notes :
# Cadastrar Livro 
# Consultar Livro
# Consultar Todos 
# Consultar por Id
# Consultar por Autor
# Retornar ao menu
# Remover Livro
# Encerrar Programa



print("\n------------------------------------------------------- ")
print("Bem-vindo ao Exercicio 4 da Camila Monteiro chaves.")
print("------------------------------------------------------- \n ")

id_global = 0
livros = []
nome = input("Insira o nome do livro? ")
autor = input("Qual o autor do livro? ")


def cadastrar_livro(id):
    livro = {
        "id": id,
        "nome": nome,
        "autor": autor
    }
    livros.append(livro)
    print("Cadastro com sucesso!")



# filtro de consulta
def consultar_livro():
    opcao = int(input("Selecione a opção desejada: \n1. Consultar Todos \n2. Consultar por ID \n3. Consultar por autor \n4. Retornar ao menu \n"))

    # todos
    if opcao == 1:
        for livro in livros:
            print( livro)
    # ID 
    elif opcao == 2:
        id = int(input("Qual é o ID do livro que você deseja consultar? "))
        for livro in livros:
            if livro["id"] == id:
             print(livro)

    # autor
    elif opcao == 3:
        autor = input("Qual é o autor do livro que você deseja consultar? ")
        for livro in livros:
            if livro["autor"] == autor:
                print(livro)
    # voltar
    elif opcao == 4:
        return
    # erro
    else:
     print("Opção inválida.")



def remover_livro():
    id = int(input("Insira o ID do livro que deseja remover? "))
    for i, livro in enumerate(livros):
     if livro["id"] == id:
       livros.pop(i)
     print("livro removido com sucesso!")
     break

def main():
 print("Olá, vamos comecar o sistema!")

 while True:
    opcao = int(input("Qual opção você deseja? \n1. Cadastrar  \n2. Consultar  \n3. Remover  \n4. Encerrar  \n"))

    # cadastrar
    if opcao == 1:
     cadastrar_livro(id_global)
     id_global += 1

     # consultar
    elif opcao == 2:
     consultar_livro()

    # remover
    elif opcao == 3:
     remover_livro()
     
     # encerrar
    elif opcao == 4:
     break

    # tratamento de erro
    else:
     print("Opção inválida.")


#parou de funcionar e eu já estava cansada não estou achando onde pode estar o erro.
## Sai do cadastro e nao entra na proxima