Website to demo all kinds of algorithms
https://www.cs.usfca.edu/~galles/visualization/Algorithms.html

Another one
https://visualgo.net/zh/heap

二叉树是很多数据结构和算法的基础。比较经典的就是堆和查找树、线段树。堆就不详细解释了，建议看看算法导论，将其吃透。
基本上会问算法的面试，一般都要问堆，甚至让你手写的。然而查找树和线段树都只是基础，以此为主干又有很多新的发展。
举例：查找树上有平衡查找树，平衡查找树又分为很多种，数据结构课本里的一般讲AVL树，除了AVL之外还有很多其他种类的平衡树，
例如acm常用的基于节点数量的平衡树：SBT（Size Balanced Tree）和Splay Tree（伸展树）。
C++和java 9 实现hashmap的神器红黑树等，都可以算作是查找树。线段树是维护区间值的神器，最简单的是单点更新。
例如n个数，每次选择一个数改变值，最终给出一堆a和b，要求[a，b]区间内的最大值或最小值，这就是一个经典的单点更新线段树的问题。
还有区间更新，例如每一次操作改变的不是一个值，而是区间[c, d]之间的数每个数都增加m。是一个区间操作，那么线段树的用法又有不同，
需要加入懒惰标记进行区间更新。

About DFS - 
https://zhuanlan.zhihu.com/p/27112937
http://chen-tao.github.io/2017/01/26/about-dfs/


Microsoft Online Assessment Questions
https://leetcode.com/discuss/interview-question/398023/Microsoft-Online-Assessment-Questions


https://www.lintcode.com/problem/?tag=microsoft

位运算：
http://graphics.stanford.edu/~seander/bithacks.html#OperationCounting