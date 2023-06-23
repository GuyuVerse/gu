import random


class gy():
    def improt(packer):
        import importlib
        module = importlib.import_module(packer)
        return module

    def gysay(saying:str):
        print(saying + " -BY顾宇")

    def type():
        gy_is=["男的","变态","男同"]
        return "是" + gy_is[random.randint(0,len(gy_is)-1)]
    
    def number(num:int):
        float_num = num+ 235.16
        return(float(float_num))
    
    def gylang():
        return("本项目为基于pyhton的为顾宇定制版,项目链接https://github.com/For_GY/GYlang")
    
    def printll(printll):
        print(str(str(printll) + " -by gylang\n"))
    
    def pay(money):
        if float(money) >= 50:
            return "爹! 爹!"
        else:
            return("穷狗去死吧傻逼")
    
    def ask_wtf(ask_what:str):
        wtf = input("顾宇正在拷打你，还不速速招来？ " + ask_what )
        if("idk" in wtf or "不知道" in wtf or "I don't know"in wtf or "我不到啊"in wtf):
            return "草泥马"
        else:
            return wtf