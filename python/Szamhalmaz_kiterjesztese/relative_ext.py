class relative_ext:
    def __init__(self, num):
        if(type(num)=="int"):
            self.num=num
            self.type = "num"
        if(type(num)=="string"):
            if(num=="inf" or num=="-inf"):
                self.num=num
                self.type = "inf"
    