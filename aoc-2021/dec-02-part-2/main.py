f = open("puzzle-input.txt")
#f = open("puzzle-input-example.txt")
instructions = f.read().splitlines()
print(instructions)

horizontal = 0
vertical = 0
aim = 0

for instruction in instructions:
    ins_val = instruction.split(" ")
    if ins_val[0] == "down": # down X increases your aim by X units.
        aim += int(ins_val[1])
        print("horizontal", horizontal, "vertical", vertical, "aim", aim)
        continue
    if ins_val[0] == "up": # up X decreases your aim by X units.
        aim -= int(ins_val[1])
        print("horizontal", horizontal, "vertical", vertical, "aim", aim)
        continue
    if ins_val[0] == "forward": # forward X does two things:
        #It increases your horizontal position by X units.
        horizontal += int(ins_val[1])
        #It increases your depth by your aim multiplied by X.
        vertical += int(ins_val[1]) * aim
        print("horizontal", horizontal, "vertical", vertical, "aim", aim)
        continue

print("product", vertical * horizontal)

