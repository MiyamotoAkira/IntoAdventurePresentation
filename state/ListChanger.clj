(ns listchanger)


(defn list-changer []
  (let [first [1 2 3]
       second (conj first 4 5)]
       (println first)
       (println second)))


(defn list-changer2 []
  (let [first [1 2 3]
       first (conj first 4 5)]
       (println first)))


(defn list-changer2' [first]
  (let [first (conj first 4 5)]
    (println first)))

(defn list-changer3 []
  (let [first [1 2 3]
        second first
        second (conj second 4 5)]
       (println first)
       (println second)))












