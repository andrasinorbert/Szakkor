import requests

# https://www.dataquest.io/blog/python-api-tutorial/

def insert_lux_ertek(ertek):
    response=requests.get(f"http://127.0.0.1:5000/lux/{ertek}")
    valasz="OK" if response.status_code ==200 else f"HIBA-{response.status_code}"
    return valasz
    
print(insert_lux_ertek(15))
