import string

def rem_punct(a):
    input_str = a
    result = input_str.translate(str.maketrans('', '', string.punctuation))
    print(result)
    return result
