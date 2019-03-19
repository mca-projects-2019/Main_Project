import string
input_str = "This &is [an] example? {of} string. with.? punctuation!!!!" # Sample string
result = input_str.translate(str.maketrans('', '', string.punctuation))
print(result)
