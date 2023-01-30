
"""
3x + 4y =54
2x-2y=32
"""
def kiirMatrix(matrix):
    [print(matrix[i]) for i in range(len(matrix))]

matrix=[
    [3,4,54],
    [2,-2,32]
]

matrix=[
    [2,-7,-12],
    [5,7,19]
]

for i in range(len(matrix)):
    elsoelem=matrix[i][0]
    for j in range(len(matrix[i])):
        matrix[i][j]/=elsoelem

kiirMatrix(matrix)

for i in range(len(matrix[0])):
    matrix[0][i]-=matrix[1][i]

kiirMatrix(matrix)
    

masodikelem=matrix[0][1]
for j in range(len(matrix[0])):
    matrix[0][j]/=masodikelem

kiirMatrix(matrix)

masodikelem=matrix[1][1]
for i in range(len(matrix[1])):
    matrix[1][i]-=(matrix[0][i]*masodikelem)

kiirMatrix(matrix)

x=matrix[1][2]
y=matrix[0][2]

print(f"x={x}; y={y}")
