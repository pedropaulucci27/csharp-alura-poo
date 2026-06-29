Episodio ep1 = new(45, "Técnicas de facilitação", 3);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");

Episodio ep2 = new(60, "Técnicas de aprendizagem", 2);
ep2.AdicionarConvidado("Leonardo");
ep2.AdicionarConvidado("Pedro");
ep2.AdicionarConvidado("Guilherme");

Podcast p1 = new("Renato", "Podcast especial");
p1.AdicionarEpisodio(ep1);
p1.AdicionarEpisodio(ep2);
p1.ExibirDetalhes();
