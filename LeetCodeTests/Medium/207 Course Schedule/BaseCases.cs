﻿using LeetCode.Medium._207_Course_Schedule;

namespace LeetCodeTests.Medium._207_Course_Schedule;

public class BaseCases {
    //There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.

    //    For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
    //Return true if you can finish all courses. Otherwise, return false.

    //Input: numCourses = 2, prerequisites = [[1,0]]
    //Output: true

    //Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
    //Output: false

    private readonly int[][] case1 = { new[] { 1, 0 } };
    private readonly int[][] case2 = { new[] { 1, 0 }, new[] { 0, 1 } };

    [Fact]
    public void BaseCase1() {
        Solution sut = new();

        var actual = sut.CanFinish(2, case1);

        Assert.True(actual);
    }

    [Fact]
    public void BaseCase2() {
        Solution sut = new();

        var actual = sut.CanFinish(2, case2);

        Assert.False(actual);
    }
}
