if __name__ == '__main__':
    n = int(input())
    isEven = n % 2 == 0
    
    if (isEven and ((n >= 2 and n <= 5) or (n > 20))):
        print('Not Weird')
    else:
        print('Weird')