import random


def attempt_board(m=4):
    n=m**2
    numbers = list(range(1,n+1))
    board = [[None for _ in range(n)]for _ in range(n)]
    for i in range(n):
        for j in range(n):
            random.shuffle(numbers)
            i0, j0 = i - i % m, j - j % m
            for x in numbers: 
                #row
                if x in board[i]:continue
                #column
                if any(row[j]==x for row in board):continue
                #block
                if any(x in row[j0:j0+m] for row in board[i0:i]) :continue
                
                board[i][j]=x
                break
            else:
                return None
    return board

def printBoard(board):
    spacer = "++----+----+----+----++----+----+----+----++----+----+----+----++----+----+----+----++"
    print(spacer.replace('-','='))
    for i, line in enumerate(board):
        print("||  {} |  {} |  {} |  {} ||  {} |  {} |  {} |  {} ||  {} |  {} |  {} |  {} ||  {} |  {} |  {} |  {} ||"
              .format(*(cell or '' for cell in line)))
        if (i+1)%4 == 0: print(spacer.replace('-','='))
        else: print(spacer)


board=None
while board == None:
    board=attempt_board()
spacer=printBoard(board)
#print(board)
print(spacer)
