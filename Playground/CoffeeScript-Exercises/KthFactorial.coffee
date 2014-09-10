# Assignments
value = 1

# Arrays
factorials = [0, 1]

# Functions:
kth_factorial = (k, n) ->
  for i in [2...n+1]
    value = value * i
    factorials.push(value)
  return factorials[k]

console.log kth_factorial(5,5)