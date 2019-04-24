import os
from uuid import uuid4
import traceback

from flask import Flask, request, render_template, send_from_directory
from scripts.speech_to_text import SpeechTotext
from scripts.text_to_speech import TextToSpeech

speech_to_text_obj = TextToSpeech()
text_to_speech_obj = SpeechTotext()

__author__ = 'ibininja'

app = Flask(__name__)
# app = Flask(__name__, static_folder="images")



APP_ROOT = os.path.dirname(os.path.abspath(__file__))

@app.route("/")
def index():
    return render_template("index.html")

@app.route('/result',methods = ['POST', 'GET'])

def result():
   if request.method == 'POST':
      result = request.form
      return render_template("uploadtwo.html")

@app.route('/resulttwo',methods = ['POST', 'GET'])

def resulttwo():
   if request.method == 'POST':
      resulttwo = request.form
      return render_template("upload.html")

@app.route("/upload", methods=["POST"])
def upload():
    try:
        text = ""
        target = os.path.join(APP_ROOT, 'audio/')
        # target = os.path.join(APP_ROOT, 'static/')
        print(target)
        if not os.path.isdir(target):
                os.mkdir(target)
        else:
            print("Couldn't create upload directory: {}".format(target))
        print(request.files.getlist("file"))
        for upload in request.files.getlist("file"):
            print(upload)
            print("{} is the file name".format(upload.filename))
            filename = upload.filename
            destination = "/".join([target, filename])
            print ("Accept incoming file:", filename)
            print ("Save it to:", destination)
            upload.save(destination)
            text = text_to_speech_obj.speech_to_text(destination)
            print("text:",text)
        return send_from_directory("text","first.txt", as_attachment=True)
    except Exception as e:
        print(str(traceback.print_exc()))
        print("Exception occured", str(e))
    return send_from_directory("text","first.txt", as_attachment=True)

@app.route("/uploadtwo", methods=["POST"])


def uploadtwo():

    try:
        text = ""
        target = os.path.join(APP_ROOT, 'text/')
        # target = os.path.join(APP_ROOT, 'static/')
        print(target)
        if not os.path.isdir(target):
                os.mkdir(target)
        else:
            print("Couldn't create upload directory: {}".format(target))
        print(request.files.getlist("file"))
        for uploadtwo in request.files.getlist("file"):
            print(uploadtwo)
            print("{} is the file name".format(uploadtwo.filename))
            filename = uploadtwo.filename
            destination = "/".join([target, filename])
            print ("Accept incoming file:", filename)
            print ("Save it to:", destination)
            uploadtwo.save(destination)
            tts = speech_to_text_obj.text_to_speech(destination)
            print("audio:",tts)
        return send_from_directory("audio","first.mp3", as_attachment=True)

    except Exception as e:
        print(str(traceback.print_exc()))
        print("Exception occured", str(e))
    return send_from_directory("audio","first.mp3", as_attachment=True)
    return redirect(url_for('uploadtwo'))

@app.route('/upload/<filename>')
def send_image(filename):
    print("file_name",filename)

    return send_from_directory("images", filename)




if __name__ == "__main__":
    app.run( debug=True)
