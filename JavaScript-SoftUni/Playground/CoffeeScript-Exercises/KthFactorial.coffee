math = require './math.js'

# Config
math.config
  number: 'bignumber'
  precision: 500

# Assignments
factorial = 1

# Functions:
kth_factorial = (k, n) ->
  try throw new Error if n < 0 || k < 0
  catch ex then return 'n and k should be positive numbers'

  for i in [1...n+1]
    factorial = math.select(math.bignumber(factorial))
                    .multiply(i)
                    .done()

  return math.pow(factorial, k)

console.log math.format(kth_factorial(-5,30))