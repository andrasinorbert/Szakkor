"""
input_file="python\gauss_eliminacio_2\input.txt"
f=open(input_file, "r")
input=f.readlines()
f.close()

sorok=[]
[sorok.append(i.strip()) for i in input]
for i in sorok:
    sor_tomb=i.split("=")
    print(sor_tomb)
"""

def kiirMatrix(matrix):
    [print(matrix[i]) for i in range(len(matrix))]

matrix=[
    [3,4,3,54],
    [2,-2,4,32],
    [3,4,-2,54]
]
sorhossz=len(matrix[0])


elsoelem=matrix[0][0]
for i in range(sorhossz):
    matrix[0][i]/=elsoelem
# 2. sor
elsoelem=matrix[1][0]
for i in range(sorhossz):
    matrix[1][i]-=elsoelem*matrix[0][i]
#3.sor
elsoelem=matrix[2][0]
for i in range(sorhossz):
    matrix[2][i]-=elsoelem*matrix[0][i]

elsoelem=matrix[1][1]
for i in range(sorhossz):
    matrix[1][i]/=elsoelem
# 1. sor
elsoelem=matrix[0][1]
for i in range(sorhossz):
    matrix[0][i]-=elsoelem*matrix[1][i]
#3.sor
elsoelem=matrix[2][1]
for i in range(sorhossz):
    matrix[2][i]-=elsoelem*matrix[1][i]

elsoelem=matrix[2][2]
for i in range(sorhossz):
    matrix[2][i]/=elsoelem
# 1. sor
elsoelem=matrix[0][2]
for i in range(sorhossz):
    matrix[0][i]-=elsoelem*matrix[2][i]
#3.sor
elsoelem=matrix[1][2]
for i in range(sorhossz):
    matrix[1][i]-=elsoelem*matrix[2][i]

kiirMatrix(matrix)




