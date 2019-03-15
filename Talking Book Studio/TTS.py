from gtts import gTTS
import os
text='ന്യൂഡൽഹി∙ വ്യോമസേന വിങ് കമാൻഡർ അഭിനന്ദൻ വർധമാനെ റാവൽപിണ്ടിയിൽനിന്ന് ലഹോറിലെത്തിച്ചു. വാഗാ അതിർത്തി '
tts = gTTS(text, lang='ml')
tts.save("good.mp3")
os.system("mpg321 good.mp3")
