export interface Category {
  id: number;
  name: string;
  imageUrl: string | null;
  categories: Category[] | null;
}
