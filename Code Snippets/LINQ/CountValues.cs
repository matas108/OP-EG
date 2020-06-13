int count = (from ar in Ar where ar.Count >= 10 && ar.Count <= 20 select ar)
    .Count();