IEnumerable<Student> Mid10and20 = Ar.Where(nn => nn.Count >= 10 && nn.Count <= 20);
IEnumerable<Studentas> MidSort1 = Mid10and20.OrderBy(nn => nn.Name);
IEnumerable<Studentas> MidSort12 = MidSort1.OrderBy(nn => nn.Count);