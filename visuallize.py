import random

import matplotlib.pyplot as plt
from matplotlib.animation import ArtistAnimation

from sort_fnc.bubblesort import bubblesort

random.seed(8888)
x = [i for i in range(1, 21)]
random.shuffle(x)
result = bubblesort(x)
fig = plt.figure()
plt.title('bubble sort')

image_list = [plt.bar(list(range(1,21)), image, color='blue')
              for image in result]

ani = ArtistAnimation(fig, image_list, interval=10)
ani.save('test.gif', writer='pillow')
print('finish')
