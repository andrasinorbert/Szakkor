
from flask import Flask
import defaults as DEF
import database_funcs as DB

# futtatas: python -m flask run

app = Flask(__name__)

@app.route("/")
def home():
    return "HOME"


@app.route("/lux/<lux_ertek>")
def lux_feltolt(lux_ertek):
    DB.insert(lux_ertek)
    return "<p style='color:red'>Feltöltve</p>"