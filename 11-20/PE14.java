package com.xtreme5351;

import java.util.Collections;
import org.apache.commons.collections4.BidiMap;
import org.apache.commons.collections4.bidimap.TreeBidiMap;

public class Problem14 {
    private int counter;
    private int maxSequenceN;
    private final BidiMap<Integer, Integer> sequencesAndLengths;

    private int collatzSequence(int n) {
        if (n == 1) {
            return counter;
        } else if (n % 2 == 0) {
            counter += 1;
            collatzSequence(n/2);
        } else {
            counter += 1;
            collatzSequence(3*n + 1);
        }
        return counter;
    }

    private void printHashMap(){
        System.out.println("===");
//        for (Integer k: sequencesAndLengths.keySet()) {
//            String key = k.toString();
//            String value = sequencesAndLengths.get(k).toString();
//            System.out.println(key + " " + value);
//        }
        System.out.println(sequencesAndLengths.keySet());
    }

    private void findMaxSeqLength(){
        for (int i = 1; i < maxSequenceN; i++) {
            counter = 1;
            sequencesAndLengths.put(i, collatzSequence(i));
            // printHashMap();
        }
        System.out.println("Greatest sequence length : " + Collections.max(sequencesAndLengths.values())
                + " | Starting number: " + sequencesAndLengths.getKey(Collections.max(sequencesAndLengths.values())));
    }

    public Problem14(){
        System.out.println("=== Problem 14 ===");
        counter = 1;
        maxSequenceN = 1000000;
        System.out.println("=== Evaluating the first " + maxSequenceN + " natural numbers ===");
        sequencesAndLengths = new TreeBidiMap<>();
        sequencesAndLengths.put(0, 0);
        findMaxSeqLength();
    }
}
