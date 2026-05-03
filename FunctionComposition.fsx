namespace myLib

module myModule = 
    let f n = n * 2
    let g n = n * n
    let gof = f >> g
    let fog = f << g
    