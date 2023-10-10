using __HeapSort;

int[] a = new int[]{
    4, 1, 3, 2, 16, 9, 10, 14, 8, 7
};

Console.WriteLine("Heap máxima:");
HeapSort.heap(a);
HeapSort.printArray(a);

Console.WriteLine("Heap mínima:");
HeapSort.minHeapfy(a);
HeapSort.printArray(a);