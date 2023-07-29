from tkinter import W


words = []

with open("words_unfiltered.txt","r") as my_file:
    for line in my_file:
        words.append(line.strip().split("\n"))

with open("words_filtered.txt","w") as my_filtered_file:
    for item in words:
        if len(item[0]) >= 4 and len(item[0]) <= 9:
            my_filtered_file.write(item[0] + "," + "\n")
