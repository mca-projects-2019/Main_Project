import re
input_str = "Box A contains 3 red and 5 white balls, while Box B contains 4 red and 2 blue balls."
result = re.sub(r'\d+', '', input_str)
print(result)
