import type { Education } from "../types/Types";

export const getEducationById = (id: number) => {
  // Detta går i vanliga fall mot ett webapi och utbildningarna ligger i en databas

  const educations: Education[] = [
    {
      id: 2,
      title: ".NET Cloud developer",
      description:
        "Som .NET Cloud Developer kommer du utveckla moderna och skalbara applikationer med Azure och .NET. Företag i alla branscher satsar på molnlösningar, och efterfrågan på utvecklare med dessa kunskaper är hög. Vill du bygga smarta system och låta din karriär ta höjd?",
    },
    {
      id: 1,
      title: ".NET uvecklare",
      description:
        "Som .NET-utvecklare arbetar du i en efterfrågad roll där du bygger säkra, effektiva lösningar för både företag och privatpersoner – inom allt från e-handel till kryptering. Vill du skapa mjukvara som är snabb, säker och byggd för framtiden? Då är vår utbildning till .NET-utvecklare rätt val för dig.",
    },
    {
      id: 3,
      title: "Frontenduvecklare",
      description:
        "Vill du jobba med webbutveckling, design och användarupplevelse? Som frontendutvecklare ser du till att webbplatser och appar är snabba, snygga och enkla att använda. Företag behöver dig för att skapa allt från e-handel till webbappar – en roll med stora jobbmöjligheter i en växande bransch.",
    },
  ];

  // Ta fram den utbilding som har det id som har skickats in
  const result: Education[] = educations.filter(
    (education) => education.id == id
  );

  return result;
};
