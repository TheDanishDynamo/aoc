f = open("puzzle-input.txt")
#f = open("puzzle-input-example.txt")
instructions = f.read().splitlines()
print(instructions)

horizontal = 0
vertical = 0

for instruction in instructions:
    ins_val = instruction.split(" ")
    if ins_val[0] == "forward":
        horizontal += int(ins_val[1])
        continue
    if ins_val[0] == "up":
        vertical -= int(ins_val[1])
        continue
    if ins_val[0] == "down":
        vertical += int(ins_val[1])
        continue

print("vertical", vertical, "horizontal", horizontal, "product", vertical*horizontal)

