import pymysql
import defaults as DEF

def conn(_host, _user, _passwd, _db_name):
    return pymysql.connect(host=_host,user=_user,passwd=_passwd,database=_db_name )

def insert(ertek):
    connection = conn(DEF.default["DB_host"],DEF.default["DB_user"], DEF.default["DB_passwd"], DEF.default["DB_name"])
    cursor = connection.cursor()
    
    connection.close()