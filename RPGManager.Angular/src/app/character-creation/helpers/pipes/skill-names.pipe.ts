// skill-names.pipe.ts
// Transforms a Skill[] into a comma-separated string of names.
// Used in step-abilities template to list background-granted skills.
import { Pipe, PipeTransform } from '@angular/core';
import { Skill } from '../../models/character-creation.models';

@Pipe({ name: 'skillNames', standalone: true, pure: true })
export class SkillNamesPipe implements PipeTransform {
    transform(skills: Skill[] | null | undefined): string {
        if (!skills?.length) return '—';
        return skills.map(s => s.name).join(', ');
    }
}