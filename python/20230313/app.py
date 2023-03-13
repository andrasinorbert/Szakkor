
from flask import Flask
import defaults as DEF
import database_funcs as DB
app = Flask(__name__)

@app.route("/")
def home():
    return "Hello, Flask!"

@app.route("/valami/")
def vmi():
    return "<p style='color:red'>SziaUram!</p>"

@app.route("/lux/<lux_ertek>")
def lux_feltolt(lux_ertek):

    
    return "<p style='color:red'>SziaUram!</p>"