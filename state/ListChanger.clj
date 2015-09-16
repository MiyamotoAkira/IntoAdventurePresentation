(ns listchanger)


(defn list-changer []
  (let [list '(1 2 3)
       list2 (conj list 4 5)]
       (println list)
       (println list2)))
