/*
641. 设计循环双端队列
https://leetcode-cn.com/problems/design-circular-deque/
*/
class MyCircularDeque {
private:
    int size, capacity;
    deque<int> q;
public:
    /** Initialize your data structure here. Set the size of the deque to be k. */
    MyCircularDeque(int k) {
        size = 0;
        capacity = k;
        //q = deque<int>(k);
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    bool insertFront(int value) {
        if (isFull()) return false;
        q.push_front(value);
        size++;
        return true;
    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    bool insertLast(int value) {
        if (isFull()) return false;
        q.push_back(value);
        size++;
        return true;
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    bool deleteFront() {
        if (isEmpty()) return false;
        q.pop_front();
        size--;
        return true;
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    bool deleteLast() {
        if (isEmpty()) return false;
        q.pop_back();
        size--;
        return true;
    }

    /** Get the front item from the deque. */
    int getFront() {
        if (isEmpty()) return -1;
        return q.front();
    }

    /** Get the last item from the deque. */
    int getRear() {
        if (isEmpty()) return -1;
        return q.back();
    }

    /** Checks whether the circular deque is empty or not. */
    bool isEmpty() {
        return q.empty();
    }

    /** Checks whether the circular deque is full or not. */
    bool isFull() {
        //cout << "size: " << size << ", capacity: " << capacity << endl;
        return size == capacity;
    }
};

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque* obj = new MyCircularDeque(k);
 * bool param_1 = obj->insertFront(value);
 * bool param_2 = obj->insertLast(value);
 * bool param_3 = obj->deleteFront();
 * bool param_4 = obj->deleteLast();
 * int param_5 = obj->getFront();
 * int param_6 = obj->getRear();
 * bool param_7 = obj->isEmpty();
 * bool param_8 = obj->isFull();
 */