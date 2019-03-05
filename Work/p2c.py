from string import ascii_letters

cipher_letters = 'yfoiazgncdmhvtqklxeswrupjbNOIQZGHFKYEVSWRCALXDMTUPJB'


def new_cipher(text):
    
    
    trans = str.maketrans(ascii_letters, cipher_letters)
    return text.translate(trans)


if __name__ == '__main__':

    opt = input('Please enter the file name with extension :')
    fn=open(opt,'r+')
    text=fn.read()
    ciphered = new_cipher(text)
    print(ciphered)

    fout=open("cipher.txt","w+")
    fout.write(ciphered)

    fn.close()
    fout.close()
    
    

   
        
