from string import ascii_letters

cipher_letters = 'hgmyqkcdwrnzftsoialxevupjbNZGHQKCDMYFOIALXEVTSWRUPJB'


def decipher(text):
    
    
    trans = str.maketrans(ascii_letters, cipher_letters)
    return text.translate(trans)


if __name__ == '__main__':

    opt = input('Please enter cipher file name with extension :')
    fn=open(opt,'r+')
    text=fn.read()
    ciphered = decipher(text)
    print(ciphered)

    fout=open("decipher.txt","w+")
    fout.write(ciphered)

    fn.close()
    fout.close()
    
    

   
        
