import pymysql
import defaults as DEF

# https://www.tutorialslides.com/how-to-connect-and-create-database-on-mysql-phpmyadmin-using-python/

def conn(_host, _user, _passwd, _db_name):
    return pymysql.connect(host=_host,user=_user,passwd=_passwd,database=_db_name )

def insert(ertek):
    connection = conn(DEF.default["DB_host"],DEF.default["DB_user"], DEF.default["DB_passwd"], DEF.default["DB_name"])
    cursor = connection.cursor()
    query=f"INSERT INTO `lux_adatok`(`value`) VALUES ('{ertek}')"
    cursor.execute(query)
    connection.commit()
    connection.close()