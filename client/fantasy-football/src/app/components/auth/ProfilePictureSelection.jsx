const profilePictures = [
  {
    id: 1,
    url: "https://res.cloudinary.com/dqixe2hf5/image/upload/v1743943011/fantasy-football-cloud/ffks8swu24mitgcyhyir.png",
    alt: "Football Avatar 1",
  },
  {
    id: 2,
    url: "https://res.cloudinary.com/dqixe2hf5/image/upload/v1743943011/fantasy-football-cloud/o7px7hxnvm95j1s1nbum.png",
    alt: "Football Avatar 2",
  },
  {
    id: 3,
    url: "https://res.cloudinary.com/dqixe2hf5/image/upload/v1743943011/fantasy-football-cloud/gm8pyukqamr1e5ikcxah.png",
    alt: "Football Avatar 3",
  },
  // Add more images as needed
];

export default function ProfilePictureSelector({ selectedPicture, onSelect }) {
  return (
    <div className="flex justify-center space-x-4">
      {profilePictures.map((picture) => (
        <img
          key={picture.id}
          src={picture.url}
          alt={picture.alt}
          className={`w-24 h-24 rounded-full cursor-pointer border-4 ${
            selectedPicture === picture.url
              ? "border-green-500"
              : "border-transparent"
          }`}
          onClick={() => onSelect(picture.url)}
        />
      ))}
    </div>
  );
}
